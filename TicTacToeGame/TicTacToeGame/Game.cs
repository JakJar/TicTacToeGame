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
    }
}
