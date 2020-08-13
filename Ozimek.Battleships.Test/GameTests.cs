using System;
using NUnit.Framework;
namespace Ozimek.Battleships.Test
{
    public class GameTests
    {

        [Test]
        public void ReturnsHitWhenShipIsInCoordinate()
        {
            Board board = new Board();
            board.AddShip(1, 0, 0, false);
            Game game = new Game(board);
            
            string response = game.TakeShot(0,0);

            Assert.AreEqual(Game.HIT, response);
        }

        [Test]
        public void ReturnsMissWhenShipIsNotInCoordinate()
        {
            Board board = new Board();
            board.AddShip(1, 1, 1, false);
            Game game = new Game(board);

            string response = game.TakeShot(0, 0);
            Assert.AreEqual(Game.MISS, response);
        }
    }
}
