using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Button;

public class Flush : Command
{
#warning This command must be tested.

    public Flush()
    {
        data =
        [
            CommandType.DirectCommand | Response.NotExpected,
            1,
            0,

            OpCode.Button,
            ButtonEvent.Flush
        ];
    }
}
