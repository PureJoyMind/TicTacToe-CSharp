using System.Xml.Linq;
using System;

namespace TicTacToe
{
    public class Player
    {
        public string Name { get; private set; }
        public string Symbol { get; private set; }

        public Player(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public int MakeMove(Board board)
        {
            int move = 0;
            do
            {
                Console.Write($"{Name}, enter a move (1-9): ");
                if (!int.TryParse(Console.ReadLine(), out move))
                {
                    move = 0;
                }
            } while (!board.UpdateBoard(move, Symbol));
            return move;
        }

    }
}