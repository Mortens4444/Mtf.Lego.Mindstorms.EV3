using Mtf.Games.Interfaces;

namespace Mtf.Lego.Mindstorms.EV3.Responses;

public class ButtonStates(byte[] rawResponse) : IButtonStates
{
    public readonly byte[] RawResponse = rawResponse;

    public bool IsUpButtonPressed()
    {
        return RawResponse[3] != 0;
    }

    public bool IsCenterButtonPressed()
    {
        return RawResponse[4] != 0;
    }

    public bool IsDownButtonPressed()
    {
        return RawResponse[5] != 0;
    }

    public bool IsRightButtonPressed()
    {
        return RawResponse[6] != 0;
    }

    public bool IsLeftButtonPressed()
    {
        return RawResponse[7] != 0;
    }

    public bool IsBackButtonPressed()
    {
        return RawResponse[8] != 0;
    }

    public bool IsAnyButtonPressed()
    {
        return RawResponse[9] != 0;
    }

    public override string ToString()
    {
        return String.Join(", ", RawResponse);
    }
}
