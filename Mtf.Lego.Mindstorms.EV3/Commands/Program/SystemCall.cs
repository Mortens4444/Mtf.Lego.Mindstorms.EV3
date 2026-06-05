using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Program;

public class SystemCall : Command
{
    public SystemCall(string command)
    {
        data = GetDirectCommandWithReply(4);
        data.Add(OpCode.System);
        data.AppendStringParameter(command);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
