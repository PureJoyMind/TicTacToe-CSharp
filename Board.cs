using System;

namespace TicTacToe
{
    public partial class Game
    {
        private class Board
        {
            private readonly string[] _spaces;

            //public int NumMoves;
            public int NumMoves { get; private set; }

            public Board()
            {
                _spaces = new string[9];
                for (int i = 0; i < _spaces.Length; i++)
                {
                    _spaces[i] = " ";
                }
            }

            public bool UpdateBoard(int move, string symbol)
            {

                if (move < 1 || move > 9)
                {
                    return false;
                }

                if (_spaces[move - 1] != " ")
                {
                    return false;
                }
                _spaces[move - 1] = symbol;
                NumMoves++;
                return true;
            }

            public void DisplayBoard()
            {
                //for (int i = 5; i < 10; i++)
                //{
                //Console.SetCursorPosition(0, i);
                //}
                Console.WriteLine($"      {_spaces[0]} | {_spaces[1]} | {_spaces[2]} ");
                Console.WriteLine("     ---+---+---");
                Console.WriteLine($"      {_spaces[3]} | {_spaces[4]} | {_spaces[5]} ");
                Console.WriteLine("     ---+---+---");
                Console.WriteLine($"      {_spaces[6]} | {_spaces[7]} | {_spaces[8]} ");
                //Console.Clear();
            }

            public bool IsGameOver()
            {
                // check rows
                for (int i = 0; i < 9; i += 3)
                {
                    if (_spaces[i] != " " && _spaces[i] == _spaces[i + 1] && _spaces[i + 1] == _spaces[i + 2])
                    {
                        return true;
                    }
                }

                // check columns
                for (int i = 0; i < 3; i++)
                {
                    if (_spaces[i] != " " && _spaces[i] == _spaces[i + 3] && _spaces[i + 3] == _spaces[i + 6])
                    {
                        return true;
                    }
                }

                // check diagonals
                if (_spaces[0] != " " && _spaces[0] == _spaces[4] && _spaces[4] == _spaces[8])
                {
                    return true;
                }
                if (_spaces[2] != " " && _spaces[2] == _spaces[4] && _spaces[4] == _spaces[6])
                {
                    return true;
                }

                // check for tie
                foreach (string space in _spaces)
                {
                    if (space == " ")
                    {
                        return false;
                    }
                }
                return true;
            }

            private static void ClearCurrentConsoleLine()
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }


        }
    }
}