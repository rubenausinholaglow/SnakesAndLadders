﻿namespace SnakesAndLadders.Classes
{
    public class Game
    {
        public bool IsFinished { get; set; } = false;

        public List<Player> Players { get; set; }

        private readonly GameCollections _gameCollections;


        public Game()
        {
            Players = new List<Player>();
            _gameCollections = new GameCollections();
        }

        public void CheckWinCondition()
        {
            IsFinished = Players.Any(p => p.Position == 100);
            if (IsFinished) GetWinner();
        }

        public void GetWinner()
        {
            var winer = Players.FirstOrDefault(p => p.Position == 100);
            Console.WriteLine($"Player {winer.Name} has won the game!");
        }

        public void CreatePlayer(string playerName)
        {
            Players.Add(new Player(playerName));
        }

        public void PlayerRoll(string playerName)
        {
            var player = GetPlayerByName(playerName);
            var diceRoll = Dice.Roll();

            player.MovePlayer(diceRoll);
            Console.WriteLine($"Player {playerName} rolls {diceRoll} and now is currently at {player.Position}");

            CheckSnakesAndLadders(player);

            CheckWinCondition();
        }

        private Player GetPlayerByName(string playerName)
        {
            return Players.FirstOrDefault(p => p.Name == playerName);
        }

        public void Play()
        {
            while (!IsFinished)
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    if (!IsFinished)
                    {
                        Console.WriteLine($"Enter to roll for {Players[i].Name}: ");
                        Console.ReadLine();
                        PlayerRoll(Players[i].Name);
                    }                    
                }
            }           
        }

        public void CheckSnakesAndLadders(Player player)
        {
            if (_gameCollections.Snakes.Any(a => a.Key == player.Position))
            {
                var snake = _gameCollections.Snakes.FirstOrDefault(a => a.Key == player.Position);
                player.Position = snake.Value;
                Console.WriteLine($"A Snake took {player.Name} and dragged from {snake.Key} to {snake.Value}");
            }
            if (_gameCollections.Ladders.Any(a => a.Key == player.Position))
            {
                var ladder = _gameCollections.Ladders.FirstOrDefault(a => a.Key == player.Position);
                player.Position = ladder.Value;
                Console.WriteLine($"{player.Name} climbed a ladder from {ladder.Key} to {ladder.Value}");
            }
        }
    }
}
