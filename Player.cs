namespace TicTacToe
{
    public class Player
    {
        public string Name { get; private set; }
        public char Symbol { get; private set; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}