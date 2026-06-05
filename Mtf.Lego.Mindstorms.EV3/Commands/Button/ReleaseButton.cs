using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Button;

public class ReleaseButton : Command
{
#warning This command must be tested.

    public ReleaseButton(ButtonType button)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.Button,
            ButtonEvent.Release,
            button
        ]);
    }
}
