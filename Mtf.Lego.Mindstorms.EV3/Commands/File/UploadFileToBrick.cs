using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class UploadFileToBrick : Command
{
    public UploadFileToBrick(string destinationFilePath, int fileSize)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.BeginFileDownload);
        data.Append(fileSize);
        data.Append(destinationFilePath);
    }
}
