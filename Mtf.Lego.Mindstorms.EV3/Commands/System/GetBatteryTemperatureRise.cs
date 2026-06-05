using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetBatteryTemperatureRise : Command
{
#warning This command must be tested.
    public GetBatteryTemperatureRise()
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryTemperatureRise,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
