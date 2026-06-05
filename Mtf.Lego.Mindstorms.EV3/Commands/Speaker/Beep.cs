using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;
using Mtf.Music;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Speaker;

public class Beep : AwaitableCommand
{
    private const ushort DefaultNoteDurationMs = 500;

    public Beep(Note note, byte volume)
        : this(volume, note, DefaultNoteDurationMs)
    { }

    public Beep(Note note, ushort durationMs, byte volume)
        : this(volume, note, durationMs)
    { }

    public Beep(byte volume, ushort frequency, ushort durationMs)
        : base(durationMs)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.Sound);
        data.Add(SoundSubCode.Tone);
        data.AppendOneBytesParameter(volume);
        data.AppendTwoBytesParameter(frequency);
        data.AppendTwoBytesParameter(durationMs);
    }
}
