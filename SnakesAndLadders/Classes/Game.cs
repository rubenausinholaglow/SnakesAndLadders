namespace SnakesAndLadders.Classes
{
    public class Game
    {
        public bool IsFinished { get; set; } = false;

        public List<Player> Players { get; set; }


        public Game()
        {
            Players = new List<Player>();
        }

        public void CheckWinCondition()
        {
            IsFinished = Players.Any(p => p.Position == 100);
        }

        public Player GetWinner()
        {
            return Players.FirstOrDefault(p => p.Position == 100);
        }
    }
}
