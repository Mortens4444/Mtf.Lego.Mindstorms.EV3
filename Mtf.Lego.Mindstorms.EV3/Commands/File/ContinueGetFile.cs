using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class ContinueGetFile : Command
{
#warning This command must be tested.
    public ContinueGetFile(byte fileHandle)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.ContinueGetFile);
        data.Add(fileHandle);
        data.Append(Constants.ChunkSize);
    }
}
