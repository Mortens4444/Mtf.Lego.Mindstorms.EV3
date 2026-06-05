using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Extensions;

public static class ByteExtensions
{
    public static bool IsSystemCommand(this byte value)
    {
        return value.IsBitSet(CommandType.SystemCommand);
    }
}
