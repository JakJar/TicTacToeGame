namespace TicTacToeGame
{
    internal class Game
    {
        private Board board;
        private int _moves;

        public Game()
        {
            board= new Board();
            _moves = 0;
        }

        public int GetValidPlayerInput()
        {
            int input;

            do
            {
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter valid number!");
                }

            } while (input is > 9 or < 1);

            return input;
        }

        public bool CheckMovementPossibility(int input)
        {
            return board.ToString().Contains(Convert.ToString(input));
        }

        public int PositionConverter(int input)
        {
            return input - 1;
        }

        public char XOrO()
        {
            if (_moves % 2 == 0)
            {
                return 'X';
            }

            return 'O';
        }
    }
}
