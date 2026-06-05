using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Program;

public abstract class StopBase : Command
{
    public StopBase(ProgramSlot programslot)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ProgramStop);
        data.Add(programslot);
    }
}
