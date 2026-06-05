using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class ChangeTopLine : LCDCommand
{
    public ChangeTopLine(State state)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.TopLine);
        data.Add(state);
    }
}
