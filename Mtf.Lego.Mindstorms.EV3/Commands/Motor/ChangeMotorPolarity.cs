using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class ChangeMotorPolarity : Command
{
#warning This command must be tested.

    public ChangeMotorPolarity(DaisyChainLayer daisyChainLayer, OutputPort outputPort, Polarity polarity)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputPolarity,
            daisyChainLayer,
            outputPort,
            polarity
        ]);
    }
}
