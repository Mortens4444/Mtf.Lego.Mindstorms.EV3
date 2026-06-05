using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Mathematics.Arithmetic;

public class Round(float value) : OneOperatorOperand(value, MathSubCode.Round)
{
}
