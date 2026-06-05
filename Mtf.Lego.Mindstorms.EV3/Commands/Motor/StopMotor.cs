using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class StopMotor : Command
{
    public StopMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort, BreakType breakType)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputStop,
            daisyChainLayer,
            outputPort,
            breakType
        ]);
    }
}
