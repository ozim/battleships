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

            CoordinatesParser parser = new CoordinatesParser();

            var output = parser.Parse(input);

            Assert.AreEqual(EXPECTED_ROW, output.Item1);
        }

        [Test]
        public void ParsesIntoExpectedColumnValue()
        {
            string input = "B10";
            const int EXPECTED_COLUMN = 1;

            CoordinatesParser parser = new CoordinatesParser();

            var output = parser.Parse(input);

            Assert.AreEqual(EXPECTED_COLUMN, output.Item2);
        }
    }
}