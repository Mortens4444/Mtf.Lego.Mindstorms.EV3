using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.File;

public class IsExists : Command
{
    public IsExists(string filePath)
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.FileName);
        data.Add(FilenameSubCode.Exist);
        data.AppendStringParameter(filePath);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
