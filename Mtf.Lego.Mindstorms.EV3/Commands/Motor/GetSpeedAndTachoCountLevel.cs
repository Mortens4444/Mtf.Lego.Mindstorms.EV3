using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class GetSpeedAndTachoCountLevel : Command
{
#warning This command must be tested.

    public GetSpeedAndTachoCountLevel(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = GetDirectCommandWithReply(5);
        data.AddRange(
        [
            OpCode.OutputRead,
            daisyChainLayer,
            outputPort,
            ParameterType.Variable | VariableScope.Global,
            1 | ParameterType.Variable | VariableScope.Global,
        ]);
    }
}
