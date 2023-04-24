using System.Xml.Linq;
using System;

namespace TicTacToe
{
    public class Player
    {
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public int Won { get; set; }
            
        public Player(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}