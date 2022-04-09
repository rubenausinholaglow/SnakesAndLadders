namespace SnakesAndLadders
{
    public class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }

        public Player(string name)
        {
            Name = name;
            Position = 1;
        }

        public int MovePlayer(int movement)
        {
            return Position += movement;
        }
    }

}
