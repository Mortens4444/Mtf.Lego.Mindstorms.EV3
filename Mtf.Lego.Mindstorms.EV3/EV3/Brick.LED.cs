using Mtf.Lego.Mindstorms.EV3.Commands.LED;
using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void ChangeLEDsState(LedPattern ledPattern)
    {
        Execute(new ChangeLedsState(ledPattern));
    }
}
