using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class ReadUltrasonicSensor : SensorRead
{
    public ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Ultrasonic, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
    }
}
