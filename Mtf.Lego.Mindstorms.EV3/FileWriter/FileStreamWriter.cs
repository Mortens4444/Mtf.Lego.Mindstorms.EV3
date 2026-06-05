namespace Mtf.Lego.Mindstorms.EV3.FileWriter;

public class FileStreamWriter(string destinationFilePath) : IWriter, IDisposable
{
    private readonly FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write);
    private bool disposed;

    ~FileStreamWriter()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Dispose(true);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                fileStream.Close();
            }

            disposed = true;
        }
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        fileStream.Write(buffer, offset, count);
        fileStream.Flush();
    }
}
