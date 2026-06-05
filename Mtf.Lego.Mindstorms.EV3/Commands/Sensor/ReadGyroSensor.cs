using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.Commands.Sensor;

public class ReadGyroSensor : SensorRead
{
    public ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Gyro, sensorMode, InputSubCode.ReadyRaw, daisyChainLayer);
    }
}
