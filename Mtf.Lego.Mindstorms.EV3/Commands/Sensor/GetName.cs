using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class GetName : Command
{
    public GetName(byte sensorPort, DaisyChainLayer daisyChainLayer)
    {
        data = GetDirectCommandWithReply(Constants.DefaultStringLength);
        data.AddRange(
        [
            OpCode.InputDevice,
            InputSubCode.GetName,
            daisyChainLayer,
            sensorPort,
            Constants.DefaultStringLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}