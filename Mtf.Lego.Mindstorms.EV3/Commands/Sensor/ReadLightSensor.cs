using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class ReadLightSensor : SensorRead
{
    public ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Color, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
    }
}
