using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class Clean : LCDCommand
{
    public Clean()
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Clean);
    }
}
