using System;

namespace TicTacToe
{
    public class Board
    {
        private string[] spaces = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public int NumMoves;

        public bool UpdateBoard(int move, string symbol)
        {
            if (move < 1 || move > 9)
            {
                return false;
            }
            else if (spaces[move - 1] != " ")
            {
                return false;
            }
            else
            {
                spaces[move - 1] = symbol;
                NumMoves++;
                return true;
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine($" {spaces[0]} | {spaces[1]} | {spaces[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {spaces[3]} | {spaces[4]} | {spaces[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {spaces[6]} | {spaces[7]} | {spaces[8]} ");
        }

        public bool IsGameOver()
        {
            // check rows
            for (int i = 0; i < 9; i += 3)
            {
                if (spaces[i] != " " && spaces[i] == spaces[i + 1] && spaces[i + 1] == spaces[i + 2])
                {
                    return true;
                }
            }

            // check columns
            for (int i = 0; i < 3; i++)
            {
                if (spaces[i] != " " && spaces[i] == spaces[i + 3] && spaces[i + 3] == spaces[i + 6])
                {
                    return true;
                }
            }

            // check diagonals
            if (spaces[0] != " " && spaces[0] == spaces[4] && spaces[4] == spaces[8])
            {
                return true;
            }
            if (spaces[2] != " " && spaces[2] == spaces[4] && spaces[4] == spaces[6])
            {
                return true;
            }

            // check for tie
            foreach (string space in spaces)
            {
                if (space == " ")
                {
                    return false;
                }
            }
            return true;
        }


    }
}