
using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1, please enter your name:");
            string player1Name = Console.ReadLine();
            Player player1 = new Player(player1Name, "X");

            Console.WriteLine("Player 2, please enter your name:");
            string player2Name = Console.ReadLine();
            Player player2 = new Player(player2Name, "O");


            // start the game
            Game game = new Game(player1, player2);
            game.StartGame();

        }
    }
}
