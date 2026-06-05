using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Error;

public class GetError : Command
{
    public GetError()
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.Info);
        data.Add(InfoSubCode.GetError);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
