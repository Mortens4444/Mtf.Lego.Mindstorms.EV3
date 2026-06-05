namespace Mtf.Lego.Mindstorms.EV3.Signaling;

public class MorseCode
{
    public char Character { get; set; }

    public List<Signal> Signals { get; set; }

    public MorseCode(char character, List<Signal> signals)
    {
        Character = character;
        Signals = signals;
    }
}
