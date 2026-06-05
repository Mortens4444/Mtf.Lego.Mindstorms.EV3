using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class OutputStart : Command
{
    public OutputStart(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputStart,
            daisyChainLayer,
            outputPort
        ]);
    }
}
