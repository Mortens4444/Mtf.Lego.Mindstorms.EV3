using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Mathematics.Logic;

public class Or : TwoOperatorOperand
{
    public Or(byte value1, byte value2)
        : base (value1, value2, OpCode.Or8)
    { }

    public Or(short value1, short value2)
        : base(value1, value2, OpCode.Or16)
    { }

    public Or(int value1, int value2)
        : base(value1, value2, OpCode.Or32)
    { }
}
