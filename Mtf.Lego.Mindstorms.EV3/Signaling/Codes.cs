namespace Mtf.Lego.Mindstorms.EV3.Signaling;

public static class Codes
{
    public static readonly List<MorseCode> MorseCodes =
    [
        new MorseCode('A', [Signal.Di, Signal.Dah]),
        new MorseCode('B', [Signal.Dah, Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('C', [Signal.Dah, Signal.Di, Signal.Dah, Signal.Di]),
        new MorseCode('D', [Signal.Dah, Signal.Di, Signal.Di]),
        new MorseCode('E', [Signal.Di]),
        new MorseCode('F', [Signal.Di, Signal.Di, Signal.Dah, Signal.Di]),
        new MorseCode('G', [Signal.Dah, Signal.Dah, Signal.Di]),
        new MorseCode('H', [Signal.Di, Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('I', [Signal.Di, Signal.Di]),
        new MorseCode('J', [Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah]),
        new MorseCode('K', [Signal.Dah, Signal.Di, Signal.Dah]),
        new MorseCode('L', [Signal.Di, Signal.Dah, Signal.Di, Signal.Di]),
        new MorseCode('M', [Signal.Dah, Signal.Dah]),
        new MorseCode('N', [Signal.Dah, Signal.Di]),
        new MorseCode('O', [Signal.Dah, Signal.Dah, Signal.Dah]),
        new MorseCode('P', [Signal.Di, Signal.Dah, Signal.Dah, Signal.Di]),
        new MorseCode('Q', [Signal.Dah, Signal.Dah, Signal.Di, Signal.Dah]),
        new MorseCode('R', [Signal.Di, Signal.Dah, Signal.Di]),
        new MorseCode('S', [Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('T', [Signal.Dah]),
        new MorseCode('U', [Signal.Di, Signal.Di, Signal.Dah]),
        new MorseCode('V', [Signal.Di, Signal.Di, Signal.Di, Signal.Dah]),
        new MorseCode('W', [Signal.Di, Signal.Dah, Signal.Dah]),
        new MorseCode('X', [Signal.Dah, Signal.Di, Signal.Di, Signal.Dah]),
        new MorseCode('Y', [Signal.Dah, Signal.Di, Signal.Dah, Signal.Dah]),
        new MorseCode('Z', [Signal.Dah, Signal.Dah, Signal.Di, Signal.Di]),
        new MorseCode('0', [Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah] ),
        new MorseCode('1', [Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah]),
        new MorseCode('2', [Signal.Di, Signal.Di, Signal.Dah, Signal.Dah, Signal.Dah]),
        new MorseCode('3', [Signal.Di, Signal.Di, Signal.Di, Signal.Dah, Signal.Dah]),
        new MorseCode('4', [Signal.Di, Signal.Di, Signal.Di, Signal.Di, Signal.Dah]),
        new MorseCode('5', [Signal.Di, Signal.Di, Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('6', [Signal.Dah, Signal.Di, Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('7', [Signal.Dah, Signal.Dah, Signal.Di, Signal.Di, Signal.Di]),
        new MorseCode('8', [Signal.Dah, Signal.Dah, Signal.Dah, Signal.Di, Signal.Di]),
        new MorseCode('9', [Signal.Dah, Signal.Dah, Signal.Dah, Signal.Dah, Signal.Di]),
        new MorseCode('?', [Signal.Di, Signal.Di, Signal.Dah, Signal.Dah, Signal.Di, Signal.Di])
    ];
}
