using System;

namespace TicTacToe
{
    public class Board
    {
        private char[] spaces = new char[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public int NumMoves;

        public bool UpdateBoard(int move, char symbol)
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


    }
}