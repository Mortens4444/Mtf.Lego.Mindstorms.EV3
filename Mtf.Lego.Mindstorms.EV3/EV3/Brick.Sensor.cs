using Mtf.Lego.Mindstorms.EV3.Commands.Input;
using Mtf.Lego.Mindstorms.EV3.Commands.Motor;
using Mtf.Lego.Mindstorms.EV3.Commands.Sensor;
using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public string GetSensorName(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
    {
        var response = Execute(new GetName(sensorPort, daisyChainLayer));
        return response.GetResponseAsString();
    }

    public void FollowLine(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
    {
        var result = Execute(new InputRead(daisyChainLayer, sensorPort));
        if (result.RawResponseData != null && result.RawResponseData.Length > 1)
        {
            var lv0 = result.RawResponseData[^1];
            lv0 /= 2;
            lv0 += 15;

            byte lv1;
            while (true)
            {
                result = Execute(new InputRead(daisyChainLayer, sensorPort));
                lv1 = result.RawResponseData[^1];

                lv1 -= lv0;
                lv1 /= 2;

                var lv2 = (byte)(40 + lv1);
                var lv3 = (byte)(40 - lv1);

                Execute(new OutputPower(daisyChainLayer, LeftMotor, lv3));
                Execute(new OutputPower(daisyChainLayer, RightMotor, lv2));
                Execute(new OutputStart(daisyChainLayer, Motors));
            }
        }
    }

    public byte[] GetSensorType(SensorPort sensorPort, DaisyChainLayer daisyChainLayer)
    {
        var result = Execute(new GetSensorType(sensorPort, daisyChainLayer));
        return result.RawResponseData;
    }

    public SensorPort GetSensor(SensorType searchedSensorType, DaisyChainLayer daisyChainLayer)
    {
        var sensorPorts = SensorPort.GetValues();
        foreach (SensorPort sensorPort in sensorPorts)
        {
            var response = GetSensorType(sensorPort, daisyChainLayer);

            var sensorType = response[3];
            //var sensorMode = response[4];

            if (sensorType == searchedSensorType)
            {
                return sensorPort;
            }
        }
        return (SensorPort)sensorPorts[0]!;
    }

    public float ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadGyroSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadLightSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadTouchSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadUltrasonicSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    public float ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        return ExecuteSensorCommand(new ReadInfraredSensor(sensorPort, sensorMode, daisyChainLayer));
    }

    private float ExecuteSensorCommand(SensorRead sensorReadCommand)
    {
        var response = Execute(sensorReadCommand);
        return sensorReadCommand.GetResult(response.RawResponseData);
    }
}
