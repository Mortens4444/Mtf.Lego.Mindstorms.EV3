using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class CreateDirectory : Command
{
    public CreateDirectory(string fullPathDirectoryName)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.CreateDir);
        data.Append(fullPathDirectoryName);
    }
}
