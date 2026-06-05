using System.IO.Pipes;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public class NamedPipeClientStreamDeviceConnection(string machine, string pipeName) : IDeviceConnection
{
    private readonly NamedPipeClientStream namedPipeClientStream = new(machine, pipeName, PipeDirection.InOut);
    private readonly IntPtr pipeHandle = NamedPipeCreator.CreatePipe(pipeName);
    private bool disposed;

    ~NamedPipeClientStreamDeviceConnection()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                namedPipeClientStream.Dispose();
            }
            NamedPipeCreator.ClosePipe(pipeHandle);

            disposed = true;
        }
    }

    public void Connect()
    {
        namedPipeClientStream.Connect();
    }

    public void Disconnect()
    {
        namedPipeClientStream.Close();
    }

    public int Read(byte[] buffer, int offset, int count)
    {
        return namedPipeClientStream.Read(buffer, offset, count);
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        namedPipeClientStream.Write(buffer, offset, count);
    }
}
