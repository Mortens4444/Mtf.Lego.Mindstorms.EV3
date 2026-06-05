using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Program;

#warning This command must be tested.
public class GetInfo : Command
{
    public GetInfo(ushort programSlotId)
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.ProgramInfo);
        data.Append(programSlotId);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
