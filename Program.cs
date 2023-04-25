
using System;
using System.Threading;

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

            while (true)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Show Stats");
                Console.WriteLine("2. Play again");
                Console.WriteLine("3. Quit");
                char answer;
                try
                {
                    answer = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(3000);
                    continue;
                }
                switch (answer)
                {
                    case '1':
                        game.ShowStats(player1, player2);
                        break;
                    case '2':
                        game.StartGame();
                        break;
                    case '3':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
