using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3;

public class SetMotorSpeedParams(OutputPort outputPort, sbyte speed)
{
    private const sbyte MaxSpeed = 100;
    private const sbyte MinSpeed = -100;

    public OutputPort OutputPort = outputPort;
    public sbyte Speed = Math.Max(Math.Min(speed, MaxSpeed), MinSpeed);
}
