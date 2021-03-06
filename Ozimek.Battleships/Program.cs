﻿using System;

namespace Ozimek.Battleships
{
    class Program
    {
        const int BATTLESHIP_SIZE = 5;
        const int DESTROYER_SIZE = 4;
        static void Main(string[] args)
        {
            var random = new Random();
            var board = new Board();
            var vertical = random.Next(0, 2) == 1;
            var startingRow = random.Next(0, 10);
            var startingColumn = random.Next(0, 10);

            while(!board.AddShip(BATTLESHIP_SIZE, startingRow, startingColumn, vertical))
            {
                vertical = random.Next(0, 2) == 1;
                startingRow = random.Next(0, 10);
                startingColumn = random.Next(0, 10);
            }

            while (!board.AddShip(DESTROYER_SIZE, startingRow, startingColumn, vertical))
            {
                vertical = random.Next(0, 2) == 1;
                startingRow = random.Next(0, 10);
                startingColumn = random.Next(0, 10);
            }

            while (!board.AddShip(DESTROYER_SIZE, startingRow, startingColumn, vertical))
            {
                vertical = random.Next(0, 2) == 1;
                startingRow = random.Next(0, 10);
                startingColumn = random.Next(0, 10);
            }

            Game game = new Game(board);
            do
            {
                Console.WriteLine("Take a shot!:");
                var coordinatesInput = Console.ReadLine();
                try
                {
                    var coordinate = new Coordinate(coordinatesInput);
                    Console.WriteLine(game.TakeShot(coordinate.Row, coordinate.Column));
                }
                catch (Exception e) when (e is FormatException || e is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Something went wrong, try again please.");
                }
            } while (!game.Finished);
        }
    }
}
