using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

/// <summary>
/// Get if a communication device is active or not.
/// </summary>
public class IsActive : Command
{
#warning This command must be tested.
    public IsActive(CommunicationInterface communicationInterface)
    {
        data = GetDirectCommandWithReply(64);
        data.AddRange(
        [
            OpCode.ComGet,
            ComGetSubCommand.GetOnOff,
            communicationInterface,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
