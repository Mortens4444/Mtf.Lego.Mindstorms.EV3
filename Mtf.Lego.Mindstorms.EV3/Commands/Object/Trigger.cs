using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Object;

/// <summary>
/// This function trigger the specific object and initaite execution if alle trigger requirements are active.
/// </summary>
public class Trigger : Command
{
#warning This command must be tested.
    public Trigger(ushort objectId)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ObjectTrigger);
        data.AppendTwoBytesParameter(objectId);
    }
}
