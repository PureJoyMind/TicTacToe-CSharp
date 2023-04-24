namespace TicTacToe
{
    public class Player
    {
        public string Name { get; private set; }
        public char Role { get; private set; }

        public Player(string name, char role)
        {
            Name = name;
            Role = role;
        }
    }
}