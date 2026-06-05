using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class GetVolume : Command
{
    public GetVolume()
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(
        [
            OpCode.Info,
            InfoSubCode.GetVolume,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
