//using Mtf.Lego.Mindstorms.EV3.Commands.LCD;
//using Mtf.Lego.Mindstorms.EV3.Drawing;
//using Mtf.Lego.Mindstorms.EV3.Enums;
//using Mtf.Lego.Mindstorms.EV3.EV3;
//using Mtf.Lego.Mindstorms.EV3.Responses;
//using Mtf.Lego.Mindstorms.EV3.Games.General;

//namespace Mtf.Lego.Mindstorms.EV3.Games.Circles;

//public class CirclesGameEngine(Brick? brick) : GameEngineBase(brick)
//{
//    private MovingHandler? movingHandler;

//    private CircleEater player = new(4);
//    private IList<CircleEater> enemies = new List<CircleEater>();
//    private readonly Random random = new(Environment.TickCount);

//    private const int NumberOfEnemies = 15;

//    protected override void StartNewGame()
//    {
//        inGame = true;
//        player = new CircleEater(LCDCommand.HorizontalCenter, LCDCommand.VerticalCenter, 4);
//        movingHandler = new MovingHandler(player);
//        enemies = [];

//        var playerZone = new EV3Circle(LCDCommand.HorizontalCenter, LCDCommand.VerticalCenter, 20, false);
//        for (int i = 0; i < NumberOfEnemies; i++)
//        {
//            CircleEater enemy;
//            do
//            {
//                enemy = new CircleEater((byte)random.Next(2, 10));
//            }
//            while (playerZone.IsColliding(enemy));
//            enemies.Add(enemy);
//        }
//    }

//    protected override ButtonStates? GameMoment()
//    {
//        player.Move();
//        bool drawPlayer = true;

//        if (inGame)
//        {
//            if (player.GetCollidingCircle(enemies) is not CircleEater enemy)
//            {
//                for (byte enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
//                {
//                    var currentEnemy = enemies[enemyIndex];
//                    currentEnemy.ChangeMoving();
//                    currentEnemy.Move();
//                    brick.Draw(currentEnemy, LCDColor.Black);
//                }
//            }
//            else
//            {
//                if (player.Radius >= enemy.Radius)
//                {
//                    enemies.Remove(enemy);
//                    brick.Draw(player, LCDColor.Black);
//                    player.IncrementRadius((byte)(enemy.Radius / 4));
//                    if (enemies.Count == 0)
//                    {
//                        message = "You won!";
//                        inGame = false;
//                    }
//                }
//                else
//                {
//                    message = GameOver;
//                    drawPlayer = false;
//                    brick.Draw(enemy, LCDColor.Black);
//                    inGame = false;
//                }
//            }

//            if (drawPlayer)
//            {
//                brick.Draw(player, LCDColor.Black);
//            }
//        }

//        return movingHandler?.HandleKeyPress(brick);
//    }
//}
