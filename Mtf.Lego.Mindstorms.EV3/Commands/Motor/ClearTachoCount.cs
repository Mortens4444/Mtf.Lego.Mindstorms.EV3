using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class ClearTachoCount : Command
{
#warning This command must be tested.

    public ClearTachoCount(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputClrCount,
            daisyChainLayer,
            outputPort
        ]);
    }
}
