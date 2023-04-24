using System;
using System.Threading;
using System.Threading.Tasks;

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
                Console.Clear();
                _board.DisplayBoard();

                // Get the current player's move
                CurrentPlayer = (_board.NumMoves % 2 == 0) ? _player1 : _player2;
                Console.WriteLine($"{CurrentPlayer.Name}, it's your turn. Please select a space on the board:");
                int move;
                try
                {
                    move = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1000);
                    continue;
                }

                // Make the move
                var isValidMove = _board.UpdateBoard(move, CurrentPlayer.Symbol);
                if (!isValidMove)
                {
                    //Console.Clear();
                    Console.WriteLine("Invalid move. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }

                // Check if the game is over
                if (!_board.IsGameOver()) continue;
                gameIsOver = true;
                Console.Clear();
                Console.WriteLine("Game over!");
                _board.DisplayBoard();
                CurrentPlayer.Won++;
                Console.WriteLine($"{CurrentPlayer.Name} wins!");
                Thread.Sleep(3000);
                break;
            }

            // Replay
            //Console.Clear();
            //Console.WriteLine("What do you want to do?");
            //Console.WriteLine("1. Show Stats");
            //Console.WriteLine("2. Play again");
            //Console.WriteLine("3. Quit");
        }

        private void ShowStats(params Player[] players)
        {
            var i = 1;
            foreach (Player player in players)
            {
                Console.WriteLine($"{i}. {player.Name}: {player.Won}");
            }
        }
    }
}