using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

/// <summary>
/// Get the pin code of the brick.
/// </summary>
public class GetPin : Command
{
    public GetPin(CommunicationInterface communicationInterface, string brickName)
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(
        [
            OpCode.ComGet,
            ComGetSubCommand.GetPin,
            communicationInterface
        ]);
        data.AppendStringParameter(brickName);

        data.Add(Constants.DefaultResponseLength);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
