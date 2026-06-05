//using Mtf.Lego.Mindstorms.EV3.Enums;
//using Mtf.Lego.Mindstorms.EV3.EV3;
//using Mtf.Lego.Mindstorms.EV3.Games.General;
//using Mtf.Lego.Mindstorms.EV3.Responses;

//namespace Mtf.Lego.Mindstorms.EV3.Games.Snake;

//public class SnakeGameEngine : GameEngineBase
//{
//    private Wormy worm = new();
//    private DirectionHandler? directionHandler;
//    private FoodProducer foodProducer = new();
//    private ScoreCounter scoreCounter = new();

//    public SnakeGameEngine(Brick? brick) : base(brick)
//    { }

//    protected override void StartNewGame()
//    {
//        worm = new Wormy();
//        directionHandler = new DirectionHandler(worm);
//        foodProducer = new FoodProducer();
//        scoreCounter = new ScoreCounter();
//        inGame = true;
//        message = GameOver;
//    }

//    protected override ButtonStates? GameMoment()
//    {
//        inGame &= worm.MoveForward();
//        if (inGame)
//        {
//            worm.Draw(brick);

//            foodProducer.DrawFood(brick);
//            if (worm.CanConsumeFood(foodProducer.GetFoodLocation()))
//            {
//                var nutrition = FoodProducer.GetFoodNutrition();
//                scoreCounter.Add(nutrition * 2);
//                if (scoreCounter.Score > Constants.MaxPoints)
//                {
//                    message = "You won!";
//                    inGame = false;
//                }
//                foodProducer.ProduceFood();
//                worm.Grow(nutrition);
//            }
//            brick.DrawString(0, 0, $"Score: {Constants.MaxPoints} / {scoreCounter.Score}", LCDColor.Black, FontType.Tiny);
//        }

//        return directionHandler?.HandleKeyPress(brick);
//    }
//}
