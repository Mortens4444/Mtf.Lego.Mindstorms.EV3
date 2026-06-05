using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Program;

public class Stop : StopBase
{
    /// <summary>
    /// Stops all running application.
    /// </summary>
    public Stop() : base(ProgramSlot.User)
    { }
}
