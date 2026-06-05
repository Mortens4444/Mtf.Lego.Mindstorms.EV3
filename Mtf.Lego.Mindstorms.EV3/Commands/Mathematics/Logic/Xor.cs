using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Mathematics.Logic;

public class Xor : TwoOperatorOperand
{
    public Xor(byte value1, byte value2)
        : base (value1, value2, OpCode.Xor8)
    { }

    public Xor(short value1, short value2)
        : base(value1, value2, OpCode.Xor16)
    { }

    public Xor(int value1, int value2)
        : base(value1, value2, OpCode.Xor32)
    { }
}
