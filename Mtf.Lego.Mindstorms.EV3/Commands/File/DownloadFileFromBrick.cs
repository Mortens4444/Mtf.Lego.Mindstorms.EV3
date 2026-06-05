using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class DownloadFileFromBrick : Command
{
    public DownloadFileFromBrick(string filePath, int fileSize)
    {
        var bytesToRead = (ushort)Math.Min(fileSize, Constants.ChunkSize);

        data = SystemCommandWithReply;
        data.Add(SystemCommand.BeginFileUpload);
        data.Append(bytesToRead);
        data.Append(filePath);
    }
}
