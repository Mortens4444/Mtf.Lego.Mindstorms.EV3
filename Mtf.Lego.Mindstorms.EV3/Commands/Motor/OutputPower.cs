using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class OutputPower : Command
{
    public OutputPower(DaisyChainLayer daisyChainLayer, OutputPort outputPort, byte power)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputPower,
            daisyChainLayer,
            outputPort,
            power
        ]);
    }
}
