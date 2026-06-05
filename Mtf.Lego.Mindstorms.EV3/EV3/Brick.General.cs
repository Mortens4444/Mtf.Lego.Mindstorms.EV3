using Mtf.Lego.Mindstorms.EV3.Commands;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public ICommandReply Execute(Command command)
    {
        ICommandReply? result = null;
        using var cancellationTokenSource = new CancellationTokenSource(Constants.CommandExecutionTimeout);
        var cancellationToken = cancellationTokenSource.Token;

        lock (commandSendingSync)
        {
            try
            {
                var messageCounterBytes = BitConverter.GetBytes(messageCounter);
                var dataToSendLength = BitConverter.GetBytes((ushort)(command.Data.Length + messageCounterBytes.Length));

                deviceConnection.Write(dataToSendLength, 0, dataToSendLength.Length);
                deviceConnection.Write(messageCounterBytes, 0, messageCounterBytes.Length);
                deviceConnection.Write(command.Data, 0, command.Data.Length);

                if (command.IsResponseRequired())
                {
                    do
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        var rawResponseData = Receive();

                        if (rawResponseData != null && rawResponseData.Length > 0)
                        {
                            result = command.Data[0].IsSystemCommand() ?
                                    new SystemCommandReply(rawResponseData) :
                                    new DirectCommandReply(rawResponseData);

                            if (result.CommandType.HasError())
                            {
                                throw new InvalidOperationException($"Error occurred: {result}");
                            }
                        }
                    } while (result?.MessageCounter != messageCounter);
                }
                messageCounter++;
            }
            catch (OperationCanceledException)
            {
                throw new TimeoutException($"The operation has timed out: {command}");
            }
        }
        return result!;
    }

    public void ExecuteAndWait(AwaitableCommand command)
    {
        Execute(command);
        Thread.Sleep(command.DurationMs);
    }

    private SystemCommandReply ExecuteSystemCommand(Command command)
    {
        var reply = Execute(command) as SystemCommandReply;
        return reply ?? throw new InvalidCastException($"Response cannot be cast to {nameof(SystemCommandReply)}.");
    }

    private byte[] Receive()
    {
        var data = new byte[2];
        _ = deviceConnection.Read(data, 0, 2);
        var expectedLength = (ushort)(data[0] | (data[1] << 8));
        var payload = new byte[expectedLength];
        _ = deviceConnection.Read(payload, 0, expectedLength);
        return payload;
    }
}
