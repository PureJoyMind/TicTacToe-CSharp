using System;

namespace TicTacToe
{
    public partial class Game
    {
        private Player CurrentPlayer { get; set;  }
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly Board _board = new Board();

        public Game(Player p1, Player p2)
        {
            _player1 = p1;
            _player2 = p2;
            //board = b;
        }

        public void StartGame()
        {
            var gameIsOver = false;

            while (!gameIsOver)
            {
                // Display the current state of the game board
                _board.DisplayBoard();

                // Get the current player's move
                CurrentPlayer = (_board.NumMoves % 2 == 0) ? _player1 : _player2;
                Console.WriteLine($"{CurrentPlayer.Name}, it's your turn. Please select a space on the board:");
                var move = Convert.ToInt32(Console.ReadLine());

                // Make the move
                var isValidMove = _board.UpdateBoard(move, CurrentPlayer.Symbol);
                if (!isValidMove)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid move. Please try again.");
                    continue;
                }

                // Check if the game is over
                if (!_board.IsGameOver()) continue;
                gameIsOver = true;
                Console.WriteLine("Game over!");
                _board.DisplayBoard();
                Console.WriteLine($"{CurrentPlayer.Name} wins!");
                break;
            }
        }
    }
}