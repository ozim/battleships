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

            const int ASCII_VALUE_FOR_A = 65;
            char columnText = input[0];
            int columnInArray = char.ToUpper(columnText) - ASCII_VALUE_FOR_A;

            return (rowInArray, columnInArray);
        }
    }
}
