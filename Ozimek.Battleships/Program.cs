using System;

namespace Ozimek.Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            do
            {
                var coordinatesInput = Console.ReadLine();
                Console.WriteLine(coordinatesInput);
                finished = coordinatesInput == "q";
            } while (!finished);

        }
    }
}
