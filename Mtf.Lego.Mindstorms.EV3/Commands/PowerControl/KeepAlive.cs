using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.PowerControl;

public class KeepAlive : Command
{
#warning This command must be tested.
    public KeepAlive(byte minutes)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.KeepAlive,
            ParameterFormat.Long | FollowType.OneByte,
            minutes
        ]);
    }
}
