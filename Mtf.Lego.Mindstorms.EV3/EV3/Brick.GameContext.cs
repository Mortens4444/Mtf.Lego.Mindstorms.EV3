using Mtf.Drawing.Interfaces;
using Mtf.Games.Interfaces;
using Mtf.Lego.Mindstorms.EV3.Commands.LCD;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Games.General;
using System.Drawing;
using PlayType = Mtf.Lego.Mindstorms.EV3.Enums.PlayType;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick : IGameContext
{
    public int ScreenWidth => LCDCommand.ScreenWidth;

    public int ScreenHeight => LCDCommand.ScreenHeight;

    public int HorizontalCenter => LCDCommand.HorizontalCenter;

    public int VerticalCenter => LCDCommand.VerticalCenter;

    public void Clear()
    {
        ClearScreen();
    }

    public void Draw(IPrimitive primitive, Color color)
    {
        Draw(primitive, ToLCDColor(color));
    }

    private static LCDColor ToLCDColor(Color color)
    {
        if (color == Color.White)
        {
            return LCDColor.White;
        }

        return LCDColor.Black;
    }

    public void Finish()
    {
        ChangeTopLine(State.Enable);
        StopApplication();
    }

    public void PlayGameOver()
    {
        PlaySound(EmbeddedSound.GameOver, PlayType.PlayOnce);
    }

    public void PlayYouWon()
    {
        PlaySound(EmbeddedSound.GoodJob, PlayType.PlayOnce);
    }

    public void ShowOnMiddleOfScreen(string v1, Drawing.FontType fontType, int v2)
    {

        ShowOnMiddleOfScreen(v1, ToEmumFontType(fontType), (byte)v2);
    }

    private static FontType ToEmumFontType(Drawing.FontType fontType)
    {
        return fontType switch
        {
            Drawing.FontType.Tiny => FontType.Tiny,
            Drawing.FontType.Normal => FontType.Normal,
            Drawing.FontType.Medium => FontType.Normal,
            Drawing.FontType.Big => FontType.Big,
            Drawing.FontType.Huge => FontType.Big,
            _ => FontType.Normal,
        };
    }

    public void StartGame()
    {
        GameFrame.UploadAndStart(this);
        ChangeTopLine(State.Disable);
    }

    public void Update()
    {
        UpdateScreen();
    }

    IButtonStates IInputContext.GetButtonStates() => GetButtonStates();
}
