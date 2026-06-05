using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.LED;

public class ChangeLedsState : Command
{
    public ChangeLedsState(LedPattern ledPattern)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.UIWrite);
        data.Add(UIWriteSubCommand.Led);
        data.AppendOneBytesParameter(ledPattern);
    }
}
