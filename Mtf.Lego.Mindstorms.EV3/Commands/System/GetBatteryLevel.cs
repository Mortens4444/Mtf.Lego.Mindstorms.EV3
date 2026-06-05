using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetBatteryLevel : Command
{
    public GetBatteryLevel()
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryLevel,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
