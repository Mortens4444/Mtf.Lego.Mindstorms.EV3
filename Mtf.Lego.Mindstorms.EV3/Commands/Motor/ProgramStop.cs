using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class ProgramStop : Command
{
#warning This command must be tested.

    public ProgramStop()
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.OutputPrgStop);
    }
}
