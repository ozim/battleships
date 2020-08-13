using System;

namespace Ozimek.Battleships
{
    class Program
    {
        const int BATTLESHIP_SIZE = 5;
        const int DESTROYER_SIZE = 4;
        static void Main(string[] args)
        {
            var random = new Random();
            bool finished = false;
            Board board = new Board();

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

            CoordinatesParser parser = new CoordinatesParser();
            do
            {
                var coordinatesInput = Console.ReadLine();
                var coordinate = parser.Parse(coordinatesInput);
                Console.WriteLine($"{coordinate.Item1} {coordinate.Item2}");
                Console.WriteLine(coordinatesInput);
                Console.WriteLine(board.GetCoordinateState(coordinate.Item1, coordinate.Item2));
                finished = coordinatesInput == "q";
            } while (!finished);

        }
    }
}
