using Mtf.Lego.Mindstorms.EV3.Commands.LCD;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Resources;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void ShowOnMiddleOfScreen(string text, FontType fontType, byte verticalDelta)
    {
        double modifier = fontType == FontType.Normal ? 4 : fontType == FontType.Big ? 8 : 2.5;
        var horizontalDelta = text.Length * modifier;

        var x = (byte)(LCDCommand.HorizontalCenter - horizontalDelta);
        var y = (byte)(LCDCommand.VerticalCenter + verticalDelta - modifier);
        DrawString(x, y, text, LCDColor.Black, fontType);
        UpdateScreen();
    }

    public void PutPixel(byte x, byte y, LCDColor color)
    {
        Execute(new PutPixel(x, y, color));
    }

    public void DrawLine(byte x1, byte y1, byte x2, byte y2, LCDColor color)
    {
        Execute(new DrawLine(x1, y1, x2, y2, color));
    }

    public void DrawCircle(byte x, byte y, byte radius, LCDColor color, bool fill = false)
    {
        Execute(new DrawCircle(x, y, radius, color, fill));
    }

    public void DrawRectangle(byte x, byte y, byte width, byte height, LCDColor color, bool fill = false)
    {
        Execute(new DrawRectangle(x, y, width, height, color, fill));
    }

    public void DrawString(byte x, byte y, string text, LCDColor color, FontType fontType)
    {
        Execute(new DrawString(x, y, text, color, fontType));
    }

    public void ChangeFontType(FontType fontType)
    {
        Execute(new ChangeFontType(fontType));
    }

    public void InverseRectangle(byte x, byte y, byte width, byte height)
    {
        Execute(new InverseRectangle(x, y, width, height));
    }

    public void ShowImage(EmbeddedImage embeddedImage)
    {
        var description = embeddedImage.GetDescription();
        var file = ResourceUploader.UploadImage(this, $"{description}{Constants.GraphicsFileExtension}");
        Execute(new ShowImage(0, 0, file, LCDColor.Black));
    }

    public void ShowImage(byte x, byte y, string imageFilePath, LCDColor color)
    {
        Execute(new ShowImage(x, y, imageFilePath, color));
    }

    public void ClearScreen()
    {
        Execute(new Clean());
    }

    public void RestoreScreen(byte level)
    {
        Execute(new Restore(level));
    }

    public void GraphDraw(byte view)
    {
        Execute(new GraphDraw(view));
    }

    public void ChangeTopLine(State state)
    {
        Execute(new ChangeTopLine(state));
    }

    public void UpdateScreen()
    {
        Execute(new Update());
    }

    public void ScreenBlock(bool set)
    {
        Execute(new ScreenBlock(set));
    }
}
