using System;
using NUnit.Framework;
namespace Ozimek.Battleships.Test
{
    public class BoardTests
    {
        [Test]
        public void AddShipWith5Parts()
        {
            Board board = new Board();

            int countHits = 0;
            const int EXPECTED_HITS = 5;


            Assert.AreEqual(EXPECTED_HITS, countHits);
        }
    }
}
