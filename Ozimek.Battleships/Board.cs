﻿using System;
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

        private bool AreCoordinatesValid(int shipSize, int startingRow, int startingColumn, bool vertical)
        {
            if (startingRow > BOARD_ROWS || startingColumn > BOARD_COLUMNS) return false;
            if (startingRow < 0 || startingColumn < 0) return false;
            int row = startingRow;
            int column = startingColumn;
            if (vertical)
            {
                if (startingRow + shipSize > BOARD_ROWS - 1)
                {
                    return false;
                };
                for (int i = 0; i < shipSize; i++)
                {
                    if (board[row, column] != 0)
                    {
                        return false;
                    }
                    row++;
                }
            }
            else
            {
                if (startingColumn + shipSize > BOARD_COLUMNS - 1)
                {
                    return false;
                };
                for (int i = 0; i < shipSize; i++)
                {
                    if (board[row, column] != 0)
                    {
                        return false;
                    }
                    column++;
                }
            }

            return true;
        }

        public bool AddShip(int shipSize, int startingRow, int startingColumn, bool vertical)
        {
            var shipIsValid = AreCoordinatesValid(shipSize, startingRow, startingColumn, vertical);
            if (shipIsValid)
            {
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
            }

            return shipIsValid;
        }

        public int GetCoordinateState(int row, int column)
        {
            return board[row, column];
        }

        public void MarkHit(int row, int column)
        {
            board[row, column] = 0;
        }
    }
}
