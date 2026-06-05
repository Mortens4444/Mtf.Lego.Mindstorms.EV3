using Mtf.Lego.Mindstorms.EV3.Commands.Program;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void Start(string command)
    {
        Execute(new Start(command));
    }

    public byte[] GetProgramInfo(ushort programSlotId)
    {
        var response = Execute(new GetInfo(programSlotId));
        return response.RawResponseData;
    }

    public void StopApplication()
    {
        Execute(new Stop());
    }

    public void StopCurrent()
    {
        Execute(new StopCurrent());
    }

    /// <summary>
    /// Execute a command.
    /// </summary>
    /// <param name="command">The command to be executed.</param>
    /// <returns>Return code of the command.</returns>
    public int SystemCall(string command)
    {
        var response = Execute(new SystemCall(command));
        return BitConverter.ToInt32(response.RawResponseData, 3);
    }
}
