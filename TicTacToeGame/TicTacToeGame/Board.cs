using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Board
    {
        private char[] _gameBoard;

        public Board()
        {
            _gameBoard = new char[9];
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
    }
}
