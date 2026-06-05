using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class GetTachoCount : Command
{
#warning This command must be tested.

    public GetTachoCount(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(
        [
            OpCode.OutputGetCount,
            daisyChainLayer,
            outputPort,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
