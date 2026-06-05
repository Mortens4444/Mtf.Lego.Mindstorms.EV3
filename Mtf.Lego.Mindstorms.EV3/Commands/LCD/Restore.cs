using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class Restore : LCDCommand
{
#warning This command must be tested.
    public Restore(byte level)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Restore);
        data.AppendOneBytesParameter(level);
    }
}
