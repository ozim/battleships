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
    }
}
