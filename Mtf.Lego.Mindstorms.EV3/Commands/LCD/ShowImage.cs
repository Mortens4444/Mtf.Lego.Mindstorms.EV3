using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class ShowImage : LCDCommand
{
    public ShowImage(byte x, byte y, string filePath, LCDColor color)
    {
        ValidatePixel(x, y);

        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.DrawUI,
            DrawSubCode.TopLine,
            0x00, // Disable

            OpCode.DrawUI,
            DrawSubCode.FillWindow,
            color == LCDColor.White ? (byte)LCDColor.Black : (byte)LCDColor.White, // BackgroundColor
        ]);

        data.AppendOneBytesParameter(0); // Start y
        data.AppendOneBytesParameter(0); // End y
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.BmpFile);
        data.Add(color);
        data.AppendOneBytesParameter(x);
        data.AppendOneBytesParameter(y);
        data.AppendStringParameter(filePath);
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Update);
    }
}
