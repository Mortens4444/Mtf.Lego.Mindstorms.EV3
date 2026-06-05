using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class ContinueDownloadFileFromBrick : Command
{
    public ContinueDownloadFileFromBrick(byte fileHandle)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.ContinueFileUpload);
        data.Add(fileHandle);
        data.Append(Constants.ChunkSize);
    }
}
