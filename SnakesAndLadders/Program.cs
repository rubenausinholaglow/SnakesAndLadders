using SnakesAndLadders.Classes;

Console.WriteLine("Hello, World!");

var NewGame = new Game();

Console.WriteLine("Enter Number of Players: ");
var playerNum = Convert.ToInt32(Console.ReadLine());

if (playerNum > 1)
{
    for(int i = 0; i < playerNum; i++)
    {
        Console.WriteLine($"Please Enter Player{i} Name: ");
        var playerName = Console.ReadLine();
        NewGame.CreatePlayer(playerName);
    }
    NewGame.Play();
}
