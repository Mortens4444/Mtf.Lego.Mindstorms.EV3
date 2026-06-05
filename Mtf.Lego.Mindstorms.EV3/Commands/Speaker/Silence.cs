using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Speaker;

public class Silence : Command
{
    public Silence()
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.Sound);
        data.Add(SoundSubCode.Break);
    }
}
