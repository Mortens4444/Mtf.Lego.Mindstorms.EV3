using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetOperatingSystemBuild : Command
{
    public GetOperatingSystemBuild()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetOperatingSystemBuild,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
