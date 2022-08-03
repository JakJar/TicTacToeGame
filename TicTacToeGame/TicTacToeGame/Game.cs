﻿namespace TicTacToeGame
{
    internal class Game
    {
        private Board board;
        private int _moves;

        public Game()
        {
            board = new Board();
            _moves = 0;
        }

        public int GetValidPlayerInput()
        {
            int input;

            do
            {
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter only numbers!");
                }
                else if (input is > 9 or < 1)
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

        public void HorizontalWin()
        {
            char[] players = { 'X', 'O' };
            char[] gameBoard = board.GetGameBoard();

            foreach (var player in players)
            {
                if ((gameBoard[0] == player && gameBoard[1] == player && gameBoard[2] == player) ||
                    (gameBoard[3] == player && gameBoard[4] == player && gameBoard[5] == player) ||
                    (gameBoard[6] == player && gameBoard[7] == player && gameBoard[8] == player))
                {
                    Console.WriteLine($"Player {player} win horizontally!");
                }
            }
        }

        public void VerticalWin()
        {
            char[] players = { 'X', 'O' };
            char[] gameBoard = board.GetGameBoard();

            foreach (char player in players)
            {
                if ((gameBoard[0] == player && gameBoard[3] == player && gameBoard[6] == player) ||
                    (gameBoard[1] == player && gameBoard[4] == player && gameBoard[7] == player) ||
                    (gameBoard[2] == player && gameBoard[5] == player && gameBoard[8] == player))
                {
                    Console.WriteLine($"Player {player} win vertically!");
                }
            }
        }

        public void DiagonalWin()
        {
            char[] players = { 'X', 'O' };
            char[] gameBoard = board.GetGameBoard();

            foreach (char player in players)
            {
                if ((gameBoard[0] == player && gameBoard[4] == player && gameBoard[8] == player) ||
                    (gameBoard[6] == player && gameBoard[4] == player && gameBoard[2] == player))
                {
                    Console.WriteLine($"Player {player} win diagonally!");
                }
            }
        }

        public void Play()
        {
            Console.Clear();
            board.DisplayBoard(board.ToString());
            while (_moves < 9)
            {
                int input = GetValidPlayerInput();
                if (CheckMovementPossibility(input))
                {
                    Console.Clear();
                    board.MarkField(PositionConverter(input), XOrO());
                    board.DisplayBoard(board.ToString());
                    _moves++;
                }
                else
                {
                    Console.WriteLine("This field is taken!");
                }
            }
        }
    }
}