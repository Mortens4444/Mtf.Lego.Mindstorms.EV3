using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class ReadTouchSensor : SensorRead
{
    public ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Touch, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
    }
}
