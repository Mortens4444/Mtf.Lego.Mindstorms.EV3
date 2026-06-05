using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class PutPixel : LCDCommand
{
    public PutPixel(byte x, byte y, LCDColor color)
    {
        ValidatePixel(x, y);

        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Pixel);
        data.AppendOneBytesParameter(color);
        data.AppendOneBytesParameter(x);
        data.AppendOneBytesParameter(y);
    }
}
