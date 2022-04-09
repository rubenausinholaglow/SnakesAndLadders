namespace SnakesAndLadders.Classes
{
    public static class GameCollections
    {
        public static List<KeyValuePair<int, int>> Ladders = new List<KeyValuePair<int, int>>() {
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

        public static List<KeyValuePair<int, int>> Snakes = new List<KeyValuePair<int, int>>() {
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
