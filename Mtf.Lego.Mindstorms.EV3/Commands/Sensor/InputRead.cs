using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class InputRead : Command
{
    public InputRead(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(
        [
            OpCode.InputRead,
            daisyChainLayer,
            sensorPort,
            SensorType.NXTLight,
            1,
            ParameterType.Variable | VariableScope.Global,
        ]);
    }
}
