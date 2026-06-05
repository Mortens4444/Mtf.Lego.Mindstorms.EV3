using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class ListOpenHandles : Command
{
#warning This command must be tested.
    public ListOpenHandles()
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.ListOpenHandles);
    }
}
