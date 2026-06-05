using System.Text;

namespace Mtf.Lego.Mindstorms.EV3.FileWriter;

public class StringWriter(int fileSize) : IWriter
{
    private readonly StringBuilder stringBuilder = new(fileSize);

    public void Write(byte[] buffer, int offset, int count)
    {
        var textPart = Constants.DefaultEncoding.GetString(buffer, offset, count);
        stringBuilder.Append(textPart);
    }

    public string GetContent()
    {
        return stringBuilder.ToString().Replace("\0", ".");
    }
}
