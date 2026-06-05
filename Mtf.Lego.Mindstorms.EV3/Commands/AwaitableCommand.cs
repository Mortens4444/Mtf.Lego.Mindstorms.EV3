namespace Mtf.Lego.Mindstorms.EV3.Commands;

public abstract class AwaitableCommand(ushort durationMs) : Command
{
    public ushort DurationMs { get; } = durationMs;
}
