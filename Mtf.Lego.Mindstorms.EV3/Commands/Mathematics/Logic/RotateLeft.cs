using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Mathematics.Logic;

public class RotateLeft : TwoOperatorOperand
{
    public RotateLeft(byte value1, byte value2)
        : base (value1, value2, OpCode.Rotate8)
    { }

    public RotateLeft(short value1, short value2)
        : base(value1, value2, OpCode.Rotate16)
    { }

    public RotateLeft(int value1, int value2)
        : base(value1, value2, OpCode.Rotate32)
    { }
}
