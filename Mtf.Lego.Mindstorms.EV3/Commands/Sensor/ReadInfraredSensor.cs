using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class ReadInfraredSensor : SensorRead
{
    public ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.IR, sensorMode, InputSubCode.ReadyRaw, daisyChainLayer, 2);
    }
}
