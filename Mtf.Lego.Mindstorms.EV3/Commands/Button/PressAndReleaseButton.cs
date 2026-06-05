using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Button;

public class PressAndReleaseButton : Command
{
#warning This command must be tested.

    public PressAndReleaseButton(ButtonType button)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.Button,
            ButtonEvent.Press,
            button,

            OpCode.Button,
            ButtonEvent.WaitForPress,

            OpCode.Button,
            ButtonEvent.Release,
            button
        ]);
    }
}
