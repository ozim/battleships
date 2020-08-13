using System;
namespace Ozimek.Battleships
{
    public class Board
    {
        const int BOARD_ROWS = 10;
        const int BOARD_COLUMNS = 10;

        private int[,] board = new int[BOARD_ROWS, BOARD_COLUMNS];
        public int RowCount { get { return BOARD_ROWS; } }
        public int ColumnCount { get { return BOARD_COLUMNS; } }

        public Board()
        {
        }

        public bool AddShip(int shipSize, int startingRow, int startingColumn, bool vertical)
        {
            if (startingRow > BOARD_ROWS || startingColumn > BOARD_COLUMNS) return false;
            if(startingRow < 0 || startingColumn < 0) return false;

            var row = startingRow;
            var column = startingColumn;

            if (vertical)
            {
                for (int i = 0; i < shipSize; i++)
                {
                    board[row, column] = 1;
                    row++;
                }
            }
            else
            {
                for (int i = 0; i < shipSize; i++)
                {
                    board[row, column] = 1;
                    column++;
                }
            }

            return true;
        }

        public int GetCoordinateState(int row, int column)
        {
            return board[row, column];
        }
    }
}
