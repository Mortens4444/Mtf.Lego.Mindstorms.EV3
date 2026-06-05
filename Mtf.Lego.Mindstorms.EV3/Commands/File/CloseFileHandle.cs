using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class CloseFileHandle : Command
{
#warning This command must be tested.
    public CloseFileHandle(byte fileHandle, string hash)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.CloseFileHandle);
        data.Add(fileHandle);
        data.Append(hash);
    }
}
