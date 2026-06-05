using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands;

public abstract class Command
{
    protected List<byte> data = [];

    public byte[] Data
    {
        get { return [.. data]; }
    }

    public bool IsResponseRequired()
    {
        return !Data[0].IsBitSet(0x80);
    }

    protected readonly List<byte> SystemCommandNoReply = [CommandType.SystemCommand | Response.NotExpected];

    protected readonly List<byte> SystemCommandWithReply = [CommandType.SystemCommand | Response.Required];

    protected readonly List<byte> DirectCommandNoReply = [CommandType.DirectCommand | Response.NotExpected, 0, 0];

    protected readonly byte DirectCommandWithReply = CommandType.DirectCommand | Response.Required;

    protected List<byte> GetDirectCommandWithReply(byte numberOfExpectedBytes, byte localBytes = 0) => [DirectCommandWithReply, numberOfExpectedBytes, (byte)(localBytes << 2)];
}
