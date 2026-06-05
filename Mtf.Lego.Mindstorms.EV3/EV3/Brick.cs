using Mtf.Lego.Mindstorms.EV3.Commands.System;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Music;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick : IDisposable
{
    #region Members

    private readonly IDeviceConnection deviceConnection;

    private ushort messageCounter = 1;
    private readonly Lock soundPlayLock = new();
    private bool disposed;
    private readonly Lock commandSendingSync = new();
    private CancellationTokenSource musicPlayerCancellationTokenSource = new();

    #endregion

    #region Properties

    public byte Volume { get; set; }

    public bool IsConnected { get; private set; }

    public OutputPort LeftMotor { get; private set; } = OutputPort.B;

    public OutputPort RightMotor { get; private set; } = OutputPort.C;

    public OutputPort LeverMotor { get; private set; } = OutputPort.A;

    public OutputPort Motors
    {
        get
        {
            return LeftMotor | RightMotor;
        }
    }

    public Melody? CurrentlyPlayedMelody { get; set; }

    #endregion

    public Brick(string port)
    {
        deviceConnection = new ComDeviceConnection(port);
    }

    public Brick(string machine, string pipeName)
    {
        deviceConnection = new NamedPipeClientStreamDeviceConnection(machine, pipeName);
    }
    
    public void Connect()
    {
        if (!IsConnected)
        {
            deviceConnection.Connect();
            IsConnected = true;

            var reply = Execute(new GetVolume());
            Volume = reply.RawResponseData[3];
        }
    }

    public void Disconnect()
    {
        if (IsConnected)
        {
            SetLargeMotorSpeed(DaisyChainLayer.EV3, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.First, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.Second, new SetMotorSpeedParams(Motors, 0));
            SetLargeMotorSpeed(DaisyChainLayer.Third, new SetMotorSpeedParams(Motors, 0));
            Silence();

            deviceConnection.Disconnect();
            IsConnected = false;
        }
    }

    ~Brick()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        Disconnect();
        if (!disposed)
        {
            if (disposing)
            {
                musicPlayerCancellationTokenSource.Dispose();
                deviceConnection.Dispose();
            }

            disposed = true;
        }
    }
}
