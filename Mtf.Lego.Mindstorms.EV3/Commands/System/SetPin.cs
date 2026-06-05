using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class SetPin : Command
{
#warning This command must be tested.
    public SetPin(CommunicationInterface communicationInterface, string brickName, string pinCode)
    {
        data =
        [
            CommandType.DirectCommand | Response.NotExpected,
            0,
            0x0C,

            OpCode.ComSet,
            ComSetSubCommand.SetPin,

            communicationInterface
        ];
        //data.AppendOneBytesParameter((byte)communicationInterface);
        data.AppendStringParameter(brickName);
        data.AppendStringParameter(pinCode);
    }
}
