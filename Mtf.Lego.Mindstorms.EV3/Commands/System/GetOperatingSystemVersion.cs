using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetOperatingSystemVersion : Command
{
    public GetOperatingSystemVersion()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetOperatingSystemVersion,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
