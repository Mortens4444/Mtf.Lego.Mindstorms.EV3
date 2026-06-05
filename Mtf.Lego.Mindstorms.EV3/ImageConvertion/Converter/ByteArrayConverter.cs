using System.Drawing;
using System.Drawing.Imaging;

namespace Mtf.Lego.Mindstorms.EV3.ImageConvertion.Converter;

public abstract class ByteArrayConverter
{
    protected static BitmapData GetBitmapData(Bitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        var lockBitsRectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
        return bitmap.LockBits(lockBitsRectangle, ImageLockMode.ReadOnly, bitmap.PixelFormat);
    }
}
