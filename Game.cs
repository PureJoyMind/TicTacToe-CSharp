using System;

namespace TicTacToe
{
    public class Game
    {
        public Player CurrentPlayer;

        public void StartGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1, please enter your name:");
            string player1Name = Console.ReadLine();
            Player player1 = new Player(player1Name, "X");

            Console.WriteLine("Player 2, please enter your name:");
            string player2Name = Console.ReadLine();
            Player player2 = new Player(player2Name, "O");

            Board board = new Board();
            bool gameIsOver = false;

            while (!gameIsOver)
            {
                // Display the current state of the game board
                board.DisplayBoard();

                // Get the current player's move
                Player currentPlayer = (board.NumMoves % 2 == 0) ? player1 : player2;
                Console.WriteLine($"{currentPlayer.Name}, it's your turn. Please select a space on the board:");
                int move = Convert.ToInt32(Console.ReadLine());

                // Make the move
                bool isValidMove = board.UpdateBoard(move, currentPlayer.Symbol);
                if (!isValidMove)
                {
                    Console.WriteLine("Invalid move. Please try again.");
                    continue;
                }

                // Check if the game is over
                if (board.IsGameOver())
                {
                    gameIsOver = true;
                    Console.WriteLine("Game over!");
                    board.DisplayBoard();
                    Console.WriteLine($"{currentPlayer.Name} wins!");
                    break;
                }
            }
        }

        public void EndGame(string winner)
        {
            Console.WriteLine("Game over!");
            if (winner == null)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine($"{winner} wins!");
            }
        }


    }
}