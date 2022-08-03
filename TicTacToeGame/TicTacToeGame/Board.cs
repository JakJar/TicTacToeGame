using System.Text;

namespace TicTacToeGame
{
    internal class Board
    {
        private char[] _gameBoard;

        public Board()
        {
            _gameBoard = new char[]{'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        }

        public void MarkField(int position, char mark)
        {
            _gameBoard[position] = mark;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _gameBoard.Length; i++)
            {
                if (_gameBoard[i] == 0)
                {
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(_gameBoard[i]);
                }
            }

            return sb.ToString();
        }

        public void DisplayBoard(string boardString)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardString[0], boardString[1], boardString[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardString[3], boardString[4], boardString[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardString[6], boardString[7], boardString[8]);
            Console.WriteLine("     |     |      ");
        }
    }
}
