using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Error;

public class GetErrorMessage : Command
{
    public GetErrorMessage(byte errrorCode)
    {
        data = GetDirectCommandWithReply(Constants.DefaultStringLength);
        data.AddRange(
        [
            OpCode.Info,
            InfoSubCode.GetErrorText,
            errrorCode,
            Constants.DefaultStringLength,
            ParameterType.Variable | VariableScope.Global
        ]);
    }
}
