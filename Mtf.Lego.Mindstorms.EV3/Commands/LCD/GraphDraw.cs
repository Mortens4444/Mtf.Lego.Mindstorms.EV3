using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class GraphDraw : LCDCommand
{
#warning This command must be tested.
    public GraphDraw(byte view)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.GraphDraw);
        data.AppendOneBytesParameter(view);
    }
}
