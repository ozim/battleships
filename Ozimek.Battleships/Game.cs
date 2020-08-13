using System;
namespace Ozimek.Battleships
{
    public class Game
    {
        public static string HIT = "Hit.";
        public static string MISS = "Miss.";
        public static string SUNK = "Sunk.";
        private Board _board;

        public Game(Board board)
        {
            _board = board;
        }

        public string TakeShot(int row, int column)
        {
            return HIT;
        }
    }
}
