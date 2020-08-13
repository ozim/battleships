using System;

namespace Ozimek.Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            CoordinatesParser parser = new CoordinatesParser();
            do
            {
                var coordinatesInput = Console.ReadLine();
                var coordinate = parser.Parse(coordinatesInput);
                Console.WriteLine($"{coordinate.Item1} {coordinate.Item2}");
                Console.WriteLine(coordinatesInput);
                finished = coordinatesInput == "q";
            } while (!finished);

        }
    }
}
