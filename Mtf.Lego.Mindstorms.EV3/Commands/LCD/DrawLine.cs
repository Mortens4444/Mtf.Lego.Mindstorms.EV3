using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class DrawLine : LCDCommand
{
    public DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Line);
        data.AppendOneBytesParameter(color);
        data.AppendOneBytesParameter(x1);
        data.AppendOneBytesParameter(y1);
        data.AppendOneBytesParameter(x2);
        data.AppendOneBytesParameter(y2);
    }
}
