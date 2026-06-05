using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Object;

/// <summary>
/// This function will make the specific execution wait until the specific object have finalized.
/// </summary>
public class Wait : Command
{
#warning This command must be tested.
    public Wait(ushort objectId)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ObjectWait);
        data.AppendTwoBytesParameter(objectId);
    }
}
