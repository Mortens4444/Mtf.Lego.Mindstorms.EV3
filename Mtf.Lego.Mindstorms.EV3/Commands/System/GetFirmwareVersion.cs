using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetFirmwareVersion : Command
{
    public GetFirmwareVersion()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetFirmwareVersion,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
