using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Speaker;

public class SpeakerIsBusy : Command
{
    public SpeakerIsBusy()
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.SoundTest);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
