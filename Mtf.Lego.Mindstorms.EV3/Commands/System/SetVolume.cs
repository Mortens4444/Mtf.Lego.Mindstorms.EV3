using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class SetVolume : Command
{
    public SetVolume(byte volume)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.Info);
        data.Add(InfoSubCode.SetVolume);
        data.AppendOneBytesParameter(volume);
    }
}
