using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class ResetMotor : Command
{
#warning This command must be tested.

    public ResetMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputReset,
            daisyChainLayer,
            outputPort
        ]);
    }
}
