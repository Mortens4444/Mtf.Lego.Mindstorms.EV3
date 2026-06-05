using Mtf.Lego.Mindstorms.EV3.Commands.Motor;
using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void SetMotors(OutputPort leftMotor, OutputPort rightMotor, OutputPort leverMotor)
    {
        LeftMotor = leftMotor;
        RightMotor = rightMotor;
        LeverMotor = leverMotor;
    }

    public byte[] GetMotorPosition(OutputPort outputPort, MotorType motorType, DaisyChainLayer daisyChainLayer)
    {
        var response = Execute(new GetMotorPosition(outputPort, motorType, daisyChainLayer));
        return response.RawResponseData;
    }

    public void SetMediumMotorSpeed(DaisyChainLayer daisyChainLayer, params SetMotorSpeedParams[] motorSpeedChanges)
    {
        foreach (var motorSpeedChange in motorSpeedChanges)
        {
            Execute(new SetMotorSpeed(motorSpeedChange, daisyChainLayer, MotorType.Medium));
        }
    }

    public void SetLargeMotorSpeed(DaisyChainLayer daisyChainLayer, params SetMotorSpeedParams[] motorSpeedChanges)
    {
        foreach (var motorSpeedChange in motorSpeedChanges)
        {
            Execute(new SetMotorSpeed(motorSpeedChange, daisyChainLayer, MotorType.Large));
        }
    }

    public void StopMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort, BreakType breakType)
    {
        Execute(new StopMotor(daisyChainLayer, outputPort, breakType));
    }

    public void ChangeMotorPolarity(DaisyChainLayer daisyChainLayer, OutputPort outputPort, Polarity polarity)
    {
        Execute(new ChangeMotorPolarity(daisyChainLayer, outputPort, polarity));
    }

    public void ResetMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        Execute(new ResetMotor(daisyChainLayer, outputPort));
    }

    public bool MotorIsBusy(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        var response = Execute(new MotorIsBusy(daisyChainLayer, outputPort));
        return response.RawResponseData[^1] != 0;
    }

    public (byte Speed, int TachoCountLevel) GetSpeedAndTachoCountLevel(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        var response = Execute(new GetSpeedAndTachoCountLevel(daisyChainLayer, outputPort));
        var speed = response.RawResponseData[3];
        var tachoCountLevel = BitConverter.ToInt32(response.RawResponseData, 4);
        return (speed, tachoCountLevel);
    }
}
