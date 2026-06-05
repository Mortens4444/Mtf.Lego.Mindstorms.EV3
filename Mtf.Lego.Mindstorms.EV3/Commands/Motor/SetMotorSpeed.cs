using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Motor;

public class SetMotorSpeed : Command
{
    public SetMotorSpeed(SetMotorSpeedParams motorSpeedChange, DaisyChainLayer daisyChainLayer, MotorType motorType)
    {
        data = DirectCommandNoReply;
        data.AddRange(
        [
            OpCode.OutputSetType,
            daisyChainLayer,
            motorSpeedChange.OutputPort,
            motorType,

            OpCode.OutputSpeed,
            daisyChainLayer,
            motorSpeedChange.OutputPort
        ]);
        data.AppendTwoBytesParameter((ushort)motorSpeedChange.Speed);
        data.AddRange(
        [
            OpCode.OutputStart,
            daisyChainLayer,
            motorSpeedChange.OutputPort
        ]);
    }
}
