using System;
using NUnit.Framework;

namespace Ozimek.Battleships.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ParsesIntoExpectedRowValue()
        {
            string input = "A10";
            const int EXPECTED_ROW = 9;

            Coordinate coordinate = new Coordinate(input);

            Assert.AreEqual(EXPECTED_ROW, coordinate.Row);
        }

        [Test]
        public void ParsesIntoExpectedColumnValue()
        {
            string input = "B10";
            const int EXPECTED_COLUMN = 1;

            Coordinate coordinate = new Coordinate(input);

            Assert.AreEqual(EXPECTED_COLUMN, coordinate.Column);
        }

        [Test]
        public void ThrowsArgumentOutOfRangeWhenRowIsAText()
        {
            string input = "BB";
            Assert.Throws<FormatException>(() => new Coordinate(input));
        }

        [Test]
        public void ThrowsArgumentOutOfRangeWhenInvalidRow()
        {
            string input = "B-1";
            Assert.Throws<ArgumentOutOfRangeException>(() => new Coordinate(input));
        }

        [Test]
        public void ThrowsArgumentOutOfRangeWhenInvalidColumn()
        {
            string input = "K10";
            Assert.Throws<ArgumentOutOfRangeException>(() => new Coordinate(input));
        }
    }
}