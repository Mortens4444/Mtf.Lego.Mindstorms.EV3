using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class DeleteFile : Command
{
    public DeleteFile(string fullPathFileName)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.DeleteFile);
        data.Append(fullPathFileName);
    }
}
