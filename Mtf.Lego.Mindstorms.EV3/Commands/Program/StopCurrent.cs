using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Program;

public class StopCurrent : StopBase
{
    /// <summary>
    /// Stops the currently running application.
    /// </summary>
    public StopCurrent() : base(ProgramSlot.Current)
    { }
}
