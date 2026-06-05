using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LCD;

public class DrawString : LCDCommand
{
    public DrawString(byte x, byte y, string text, LCDColor color, FontType fontType)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.SelectFont);
        data.Add(fontType);
        data.Add(OpCode.DrawUI);
        data.Add(DrawSubCode.Text);
        data.AppendOneBytesParameter(color);
        data.AppendTwoBytesParameter(x);
        data.AppendTwoBytesParameter(y);
        data.AppendStringParameter(text);
    }
}
