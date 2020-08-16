using System;
namespace Ozimek.Battleships
{
    public class Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            if (row < 0 || row > 9) throw new ArgumentOutOfRangeException("row");
            if (column < 0 || column > 9) throw new ArgumentOutOfRangeException("column");

            Row = row;
            Column = column;
        }

        public Coordinate(string input)
        {
            string rowText = input.Substring(1);
            int rowInArray = int.Parse(rowText) - 1;

            const int ASCII_VALUE_FOR_A = 65;
            char columnText = input[0];
            int columnInArray = char.ToUpper(columnText) - ASCII_VALUE_FOR_A;

            if (rowInArray < 0 || rowInArray > 9) throw new ArgumentOutOfRangeException("row");
            if (columnInArray < 0 || columnInArray > 9) throw new ArgumentOutOfRangeException("column");

            Row = rowInArray;
            Column = columnInArray;
        }
    }
}
