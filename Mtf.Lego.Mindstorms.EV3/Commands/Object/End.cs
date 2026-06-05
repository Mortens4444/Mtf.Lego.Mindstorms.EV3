using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Object;

/// <summary>
/// This function should be used in the end of object to indicated the end of the object.
/// </summary>
public class End : Command
{
#warning This command must be tested.
    public End()
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ObjectEnd);
    }
}
