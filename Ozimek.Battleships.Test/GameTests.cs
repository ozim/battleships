using NUnit.Framework;
namespace Ozimek.Battleships.Test
{
    public class GameTests
    {
        [Test]
        public void ReturnsHitWhenShipIsInCoordinate()
        {
            Board board = new Board();
            board.AddShip(2, 0, 0, false);
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

        [Test]
        public void ReturnsSunkWhenShipIsInCoordinateAndNoMorePartsLeft()
        {
            Board board = new Board();
            board.AddShip(1, 0, 0, false);
            Game game = new Game(board);

            string response = game.TakeShot(0, 0);

            Assert.AreEqual(Game.SUNK, response);
        }

        [Test]
        public void AfterHitBoardMarksCoordinateAsMiss()
        {
            Board board = new Board();
            board.AddShip(2, 0, 0, false);
            Game game = new Game(board);

            game.TakeShot(0, 0);
            string response = game.TakeShot(0, 0);

            Assert.AreEqual(Game.MISS, response);
        }

        [Test]
        public void WhenShipIsPresentEndGameNotSet()
        {
            int shipLength = 1;
            Board board = new Board();
            board.AddShip(shipLength, 0, 0, false);

            Game game = new Game(board);

            Assert.IsFalse(game.Finished);
        }

        [Test]
        public void WhenAllShipsAreGoneEndGame()
        {
            int shipLength = 1;
            Board board = new Board();
            board.AddShip(shipLength, 0, 0, false);
            Game game = new Game(board);

            game.TakeShot(0, 0);

            Assert.True(game.Finished);
        }
    }
}
