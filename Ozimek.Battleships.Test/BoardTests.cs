using System;
using NUnit.Framework;
namespace Ozimek.Battleships.Test
{
    public class BoardTests
    {
        [Test]
        public void AddShipWith5Parts()
        {
            int countHits = 0;
            const int EXPECTED_HITS = 5;

            Board board = new Board();
            board.AddShip(EXPECTED_HITS, 0, 0, false);
            for (int i = 0; i < board.RowCount; i++)
            {
                for (int j = 0; j < board.ColumnCount; j++)
                {
                    if (board.GetCoordinateState(i, j) > 0) countHits++;
                }
            }


            Assert.AreEqual(EXPECTED_HITS, countHits);
        }

        [Test]
        public void AddShipInvalidColumnReturnsFalse()
        {

            const int EXPECTED_HITS = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(EXPECTED_HITS, 0, 11, false);

            Assert.False(shipAdded);
        }

        [Test]
        public void AddShipInvalidRowReturnsFalse()
        {

            const int EXPECTED_HITS = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(EXPECTED_HITS, -1, 8, false);

            Assert.False(shipAdded);
        }

        [Test]
        public void AddShipInvalidColumnBelowRangeReturnsFalse()
        {
            int shipLength = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(shipLength, 0, -11, false);

            Assert.False(shipAdded);
        }

        [Test]
        public void AddShipInvalidRowAboveRangeReturnsFalse()
        {
            int shipLength = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(shipLength, 11, 8, false);

            Assert.False(shipAdded);
        }

        [Test]
        public void AddShipEndingOutsideOfBoardReturnsFalse()
        {

            int shipLength = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(shipLength, 8, 8, false);

            Assert.False(shipAdded);
        }

        [Test]
        public void AddShipOverlappingWithOtherShipReturnsFalse()
        {
            int shipLength = 5;

            Board board = new Board();
            var shipAdded = board.AddShip(shipLength, 0, 0, false);
            Assert.True(shipAdded);

            shipAdded = board.AddShip(shipLength, 0, 0, false);
            Assert.False(shipAdded);
        }
    }
}
