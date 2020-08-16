namespace Ozimek.Battleships
{
    public class Game
    {
        public static string HIT = "Hit.";
        public static string MISS = "Miss.";
        public static string SUNK = "Sunk.";
        private Board _board;
        public bool Finished
        {
            get
            {
                return _board.NoShipsLeft();
            }
        }

        public Game(Board board)
        {
            _board = board;
        }

        public string TakeShot(int row, int column)
        {
            var currentHitShip = _board.GetCoordinateState(row, column);

            if (currentHitShip > 0)
            {
                _board.MarkHit(row, column);
                int remainingPices = 0;
                for (int i = 0; i < _board.RowCount; i++)
                {
                    for (int j = 0; j < _board.ColumnCount; j++)
                    {
                        if (_board.GetCoordinateState(i, j) == currentHitShip)
                        {
                            remainingPices++;
                        }
                    }
                }
                if (remainingPices == 0)
                {
                    return SUNK;
                }

                return HIT;
            }

            return MISS;
        }
    }
}
