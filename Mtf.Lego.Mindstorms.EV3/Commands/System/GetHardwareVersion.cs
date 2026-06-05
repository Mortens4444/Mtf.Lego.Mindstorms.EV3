using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetHardwareVersion : Command
{
    public GetHardwareVersion()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetHardwareVersion,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
