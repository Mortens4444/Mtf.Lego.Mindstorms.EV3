using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class ScreenBlock : LCDCommand
{
    public ScreenBlock(bool set)
    {
        var block = (byte)(set ? 1 : 0);
        data = DirectCommandNoReply;
        data.Add(OpCode.UIWrite);
        data.Add(UIWriteSubCommand.ScreenBlock);
        data.Add(block);
    }
}
