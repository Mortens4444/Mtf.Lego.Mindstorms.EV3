//using Mtf.Lego.Mindstorms.EV3.EV3;
//using Mtf.Lego.Mindstorms.EV3.Responses;

//namespace Mtf.Lego.Mindstorms.EV3.Games.General;

//public class DirectionHandler(IDirectable directable)
//{
//    private readonly IDirectable directable = directable;

//    public ButtonStates HandleKeyPress(Brick brick)
//    {
//        var buttonStates = brick.GetButtonStates();
//        if (buttonStates.IsRightButtonPressed())
//        {
//            directable.ChangeDirection(Direction.East);
//        }
//        else if (buttonStates.IsLeftButtonPressed())
//        {
//            directable.ChangeDirection(Direction.West);
//        }
//        else if (buttonStates.IsDownButtonPressed())
//        {
//            directable.ChangeDirection(Direction.South);
//        }
//        else if (buttonStates.IsUpButtonPressed())
//        {
//            directable.ChangeDirection(Direction.North);
//        }
//        return buttonStates;
//    }
//}
