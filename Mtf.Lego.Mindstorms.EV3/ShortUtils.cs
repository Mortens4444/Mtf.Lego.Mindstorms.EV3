namespace Mtf.Lego.Mindstorms.EV3;

public static class ShortUtils
{
    public static void Swap(ref short a, ref short b)
    {
        a ^= b;
        b ^= a;
        a ^= b;
    }
}
