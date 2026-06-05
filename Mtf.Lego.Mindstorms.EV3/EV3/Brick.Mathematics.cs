using Mtf.Lego.Mindstorms.EV3.Commands.Mathematics.Arithmetic;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public float Add(float value1, float value2)
    {
        var response = Execute(new Add(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Subtract(float value1, float value2)
    {
        var response = Execute(new Subtract(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Multiply(float value1, float value2)
    {
        var response = Execute(new Multiply(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float Divide(float value1, float value2)
    {
        var response = Execute(new Divide(value1, value2));
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }
}
