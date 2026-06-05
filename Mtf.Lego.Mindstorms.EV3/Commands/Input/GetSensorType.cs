using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Input;

public class GetSensorType : Command
{
    public GetSensorType(SensorPort sensorPort, DaisyChainLayer daisyChainLayer)
    {
        data = GetDirectCommandWithReply(2);
        data.AddRange(
        [
            OpCode.InputDevice,
            InputSubCode.GetTypeMode,
            daisyChainLayer,
            sensorPort,
            2,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
