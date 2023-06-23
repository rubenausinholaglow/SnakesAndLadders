namespace SnakesAndLadders.Classes
{
    public class GameCollections
    {
        public List<KeyValuePair<int, int>> Snakes { get; set; }
        public List<KeyValuePair<int, int>> Ladders { get; set; }

        public GameCollections()
        {
            Snakes = GetSnakes();
            Ladders = GetLadders();
        }

        private List<KeyValuePair<int, int>> GetLadders()
        {
            return new List<KeyValuePair<int, int>>() {
                            new KeyValuePair<int, int>(2, 38),
                            new KeyValuePair<int, int>(7, 14),
                            new KeyValuePair<int, int>(8, 31),
                            new KeyValuePair<int, int>(15, 26),
                            new KeyValuePair<int, int>(21, 42),
                            new KeyValuePair<int, int>(28, 84),
                            new KeyValuePair<int, int>(36, 44),
                            new KeyValuePair<int, int>(51, 67),
                            new KeyValuePair<int, int>(71, 91),
                            new KeyValuePair<int, int>(78, 98),
                            new KeyValuePair<int, int>(87, 94)
                };
        }
        private List<KeyValuePair<int, int>> GetSnakes()
        {
            return new List<KeyValuePair<int, int>>() {
                            new KeyValuePair<int, int>(16, 6),
                            new KeyValuePair<int, int>(46, 25),
                            new KeyValuePair<int, int>(49, 11),
                            new KeyValuePair<int, int>(62, 19),
                            new KeyValuePair<int, int>(64, 60),
                            new KeyValuePair<int, int>(74, 53),
                            new KeyValuePair<int, int>(89, 68),
                            new KeyValuePair<int, int>(92, 88),
                            new KeyValuePair<int, int>(95, 75),
                            new KeyValuePair<int, int>(99, 80)
                };
        }

    }
}
