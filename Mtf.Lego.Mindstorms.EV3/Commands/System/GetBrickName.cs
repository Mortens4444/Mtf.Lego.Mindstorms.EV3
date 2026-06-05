using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

/// <summary>
/// Get the name of the brick.
/// </summary>
public class GetBrickName : Command
{
    public GetBrickName()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.ComGet,
            ComGetSubCommand.GetBrickName,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
