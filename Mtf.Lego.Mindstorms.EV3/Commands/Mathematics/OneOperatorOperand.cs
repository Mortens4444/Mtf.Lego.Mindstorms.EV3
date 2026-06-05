using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Mathematics;

public abstract class OneOperatorOperand : Command
{
    public OneOperatorOperand(float value, MathSubCode mathSubCode)
    {
        data = GetDirectCommandWithReply(4);
        data.Add(OpCode.Math);
        data.Add(mathSubCode);
        data.AppendFourBytesParameter(value);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
