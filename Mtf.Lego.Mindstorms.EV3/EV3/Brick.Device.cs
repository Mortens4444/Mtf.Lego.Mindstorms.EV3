using Mtf.Lego.Mindstorms.EV3.Commands.Error;
using Mtf.Lego.Mindstorms.EV3.Commands.PowerControl;
using Mtf.Lego.Mindstorms.EV3.Commands.System;
using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public void KeepAlive(byte minutes)
    {
        Execute(new KeepAlive(minutes));
    }

    public string GetBrickName()
    {
        var response = Execute(new GetBrickName());
        return response.GetResponseAsString();
    }

    public bool IsActive(CommunicationInterface communicationInterface)
    {
        var response = Execute(new IsActive(communicationInterface));
        return Convert.ToBoolean(response.RawResponseData[3]);
    }

    public void SetBrickName(string brickName)
    {
        Execute(new SetBrickName(brickName));
    }

    public string GetPin(CommunicationInterface communicationInterface, string brickName)
    {
        var response = Execute(new GetPin(communicationInterface, brickName));
        return response.GetResponseAsString();
    }

    public void SetPin(CommunicationInterface communicationInterface, string brickName, string pinCode)
    {
        Execute(new SetPin(communicationInterface, brickName, pinCode));
    }

    public float GetBatteryVoltage()
    {
        var response = Execute(new GetBatteryVoltage());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public float GetBatteryCurrent()
    {
        var response = Execute(new GetBatteryCurrent());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public byte GetBatteryLevel()
    {
        var response = Execute(new GetBatteryLevel());
        return response.RawResponseData[3];
    }

    public float GetBatteryTemperatureRise()
    {
        var response = Execute(new GetBatteryTemperatureRise());
        return BitConverter.ToSingle(response.RawResponseData, 3);
    }

    public string GetOperatingSystemVersion()
    {
        var response = Execute(new GetOperatingSystemVersion());
        return response.GetResponseAsString();
    }

    public string GetOperatingSystemBuild()
    {
        var response = Execute(new GetOperatingSystemBuild());
        return response.GetResponseAsString();
    }

    public string GetHardwareVersion()
    {
        var response = Execute(new GetHardwareVersion());
        return response.GetResponseAsString();
    }

    public string GetFirmwareVersion()
    {
        var response = Execute(new GetFirmwareVersion());
        return response.GetResponseAsString();
    }

    public string GetFirmwareBuild()
    {
        var response = Execute(new GetFirmwareBuild());
        return response.GetResponseAsString();
    }

    public string GetLastError()
    {
        var reply = Execute(new GetError());
        var errorCode = reply.RawResponseData[3];
        reply = Execute(new GetErrorMessage(errorCode));
        var message = Constants.DefaultEncoding.GetString(reply.RawResponseData, 3, Constants.DefaultResponseLength);
        if (String.IsNullOrEmpty(message))
        {
            message = "N/A";
        }
        return $"{errorCode}: {message}";
    }
}
