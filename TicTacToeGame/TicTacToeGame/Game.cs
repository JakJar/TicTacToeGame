using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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
    }
}
