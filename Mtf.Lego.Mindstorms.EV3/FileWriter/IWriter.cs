namespace Mtf.Lego.Mindstorms.EV3.FileWriter;

public interface IWriter
{
    void Write(byte[] buffer, int offset, int count);
}