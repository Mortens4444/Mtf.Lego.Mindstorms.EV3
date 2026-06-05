using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class GetFile : Command
{
#warning This command must be tested.
    public GetFile(string filePath)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.BeginGetFile);
        data.Append(Constants.ChunkSize);
        data.Append(filePath);
    }
}
