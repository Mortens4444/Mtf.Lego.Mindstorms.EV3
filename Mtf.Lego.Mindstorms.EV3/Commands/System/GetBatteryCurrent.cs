using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetBatteryCurrent : Command
{
    public GetBatteryCurrent()
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(
        [
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryCurrent,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
