using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Extensions;

public static class CommandTypeExtensions
{
    public static bool HasError(this CommandType commandType)
    {
        return commandType == CommandType.SystemCommandReplyWithError || commandType == CommandType.DirectCommandReplyWithError;
    }
}
