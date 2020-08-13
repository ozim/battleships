using System;
namespace Ozimek.Battleships
{
    public class CoordinatesParser
    {
        public CoordinatesParser()
        {
        }

        public (int,int) Parse(string input)
        {
            string rowText = input.Substring(1);
            int rowInArray = int.Parse(rowText) - 1;

            return (rowInArray, 0);
        }
    }
}
