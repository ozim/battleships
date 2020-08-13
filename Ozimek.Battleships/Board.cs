using System;
namespace Ozimek.Battleships
{
    public class Board
    {
        const int BOARD_ROWS = 10;
        const int BOARD_COLUMNS = 10;

        private int[,] board = new int[BOARD_ROWS, BOARD_COLUMNS];

        public Board()
        {
        }

        public void AddShip(int shipSize, int startingRow, int startingColumn, bool vertical)
        {

        }

        public int GetCoordinateState(int row, int column)
        {
            return board[row, column];
        }
    }
}
