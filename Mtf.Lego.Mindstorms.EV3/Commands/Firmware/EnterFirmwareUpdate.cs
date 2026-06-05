using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Firmware;

public class EnterFirmwareUpdate : Command
{
#warning This command must be tested.
    public EnterFirmwareUpdate()
    {
        data = SystemCommandNoReply;
        data.Add(SystemCommand.EnterFirmwareUpdate);
    }
}
