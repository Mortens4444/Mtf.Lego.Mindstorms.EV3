using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetBatteryVoltage : Command
{
    public GetBatteryVoltage()
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryVoltage,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
