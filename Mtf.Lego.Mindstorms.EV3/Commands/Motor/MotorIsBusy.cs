using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class MotorIsBusy : Command
{
#warning This command must be tested.

    public MotorIsBusy(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(
        [
            OpCode.OutputTest,
            daisyChainLayer,
            outputPort,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
