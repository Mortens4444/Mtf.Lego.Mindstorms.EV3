using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.EV3;
using Mtf.Lego.Mindstorms.EV3.Resources;

namespace Mtf.Lego.Mindstorms.EV3.Games.General;

public static class GameFrame
{
    /// <summary>
    /// Dirty hack to get an application running in the background.
    /// </summary>
    /// <param name="brick">The EV3 brick</param>
    public static void UploadAndStart(Brick brick)
    {
        var destinationAppName = ResourceUploader.UploadApplication(brick, "GameFrame.rbf");
        brick.Start(destinationAppName);
        brick.ChangeLEDsState(LedPattern.Off);
    }
}
