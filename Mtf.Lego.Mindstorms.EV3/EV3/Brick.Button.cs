using Mtf.Lego.Mindstorms.EV3.Commands.Button;
using Mtf.Lego.Mindstorms.EV3.Commands.PowerControl;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Responses;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public ButtonStates GetButtonStates()
    {
        var response = Execute(new GetButtonStates());
        return new ButtonStates(response.RawResponseData);
    }

    public void PressButton(ButtonType button)
    {
        Execute(new PressButton(button));
    }

    public void PressAndReleaseButton(ButtonType button)
    {
        Execute(new PressAndReleaseButton(button));
    }

    public void ReleaseButton(ButtonType button)
    {
        Execute(new ReleaseButton(button));
    }

    public void Flush()
    {
        Execute(new Flush());
    }

    public void Shutdown()
    {
        Execute(new Shutdown());
    }
}
