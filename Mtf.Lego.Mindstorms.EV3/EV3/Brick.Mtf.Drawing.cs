using Mtf.Drawing.Geometry;
using Mtf.Drawing.Interfaces;
using Mtf.Drawing.Render;
using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void Draw(IPrimitive element, LCDColor color)
    {
        switch (element)
        {
            case PointPrimitive point:
                PutPixel(Convert.ToByte(point.ShapeData.Point.X), Convert.ToByte(point.ShapeData.Point.Y), color);
                break;
            case LinePrimitive line:
                DrawLine(line, color);
                break;
            case CirclePrimitive circle:
                DrawCircle(circle, color);
                break;
            case TextPrimitive text:
                DrawString(text);
                break;
            case RectanglePrimitive rectangle:
                DrawRectangle(rectangle, color);
                break;
            case InverseRectanglePrimitive inverseRectangle:
                InverseRectangle(inverseRectangle);
                break;
            default:
                break;
        }
    }

    public void PutPixel(PointPrimitive point, LCDColor color)
    {
        PutPixel(Convert.ToByte(point.ShapeData.Point.X), Convert.ToByte(point.ShapeData.Point.Y), color);
    }

    public void DrawLine(LinePrimitive line, LCDColor color)
    {
        DrawLine(Convert.ToByte(line.Line.A.X), Convert.ToByte(line.Line.A.Y), Convert.ToByte(line.Line.B.X), Convert.ToByte(line.Line.B.Y), color);
    }

    public void DrawCircle(CirclePrimitive circle, LCDColor color)
    {
        DrawCircle(Convert.ToByte(circle.Center.X), Convert.ToByte(circle.Center.Y), Convert.ToByte(circle.Radius), color, circle.Fill);
    }

    public void DrawRectangle(RectanglePrimitive rectangle, LCDColor color)
    {
        DrawRectangle(Convert.ToByte(rectangle.Rect.X), Convert.ToByte(rectangle.Rect.Y), Convert.ToByte(rectangle.Rect.Width), Convert.ToByte(rectangle.Rect.Height), color, rectangle.Fill);
    }

    public void DrawString(TextPrimitive text)
    {
        DrawString(Convert.ToByte(text.Layout.Position.X), Convert.ToByte(text.Layout.Position.Y), text.Layout.Text, LCDColor.Black, FontType.Normal);
    }

    public void InverseRectangle(InverseRectanglePrimitive rectangle)
    {
        InverseRectangle(Convert.ToByte(rectangle.Rect.X), Convert.ToByte(rectangle.Rect.Y), Convert.ToByte(rectangle.Rect.Width), Convert.ToByte(rectangle.Rect.Height));
    }
}
