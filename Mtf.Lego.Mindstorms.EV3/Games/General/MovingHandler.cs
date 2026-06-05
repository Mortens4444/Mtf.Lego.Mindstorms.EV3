//using Mtf.Lego.Mindstorms.EV3.EV3;
//using Mtf.Lego.Mindstorms.EV3.Responses;

//namespace Mtf.Lego.Mindstorms.EV3.Games.General;

//public class MovingHandler(IMoveable moveable)
//{
//    private readonly IMoveable moveable = moveable;

//    public ButtonStates HandleKeyPress(Brick brick)
//    {
//        var buttonStates = brick.GetButtonStates();
//        moveable.MoveRight(buttonStates.IsRightButtonPressed());
//        moveable.MoveLeft(buttonStates.IsLeftButtonPressed());
//        moveable.MoveDown(buttonStates.IsDownButtonPressed());
//        moveable.MoveUp(buttonStates.IsUpButtonPressed());
//        return buttonStates;
//    }
//}
