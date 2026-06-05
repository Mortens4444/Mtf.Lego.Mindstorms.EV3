using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.PowerControl;

public class Shutdown : Command
{
    public Shutdown()
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.Button,
            ButtonEvent.Press,
            ButtonType.Back,

            OpCode.Button,
            ButtonEvent.WaitForPress,

            OpCode.Button,
            ButtonEvent.Press,
            ButtonType.Right,

            OpCode.Button,
            ButtonEvent.WaitForPress,

            OpCode.Button,
            ButtonEvent.Press,
            ButtonType.Center
        ]);
    }
}
