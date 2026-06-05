using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Button;

public class PressButton : Command
{
#warning This command must be tested.

    public PressButton(ButtonType button)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.Button,
            ButtonEvent.Press,
            button,

            OpCode.Button,
            ButtonEvent.WaitForPress
        ]);
    }
}
