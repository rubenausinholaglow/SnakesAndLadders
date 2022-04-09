namespace SnakesAndLadders.Classes
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

        public void MovePlayer(int movement)
        {
            if(Position + movement < 101)
            {
                Position += movement;
            }
        }
    }

}
