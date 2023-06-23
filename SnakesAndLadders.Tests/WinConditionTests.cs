using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Classes;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class WinConditionTests
    {
        [TestMethod]
        // UAT1
        public void When_Token_Is_At_Positon_97_And_Add_3_Player_Wins()
        {
            // Arrange
            Game game = new Game();
            game.Players.Add(new Player("Player1"));

            // Act
            game.Players.Find(p => p.Name == "Player1").Position = 97;
            game.Players.Find(p => p.Name == "Player1").MovePlayer(3);
            game.CheckWinCondition();

            // Assert
            Assert.AreEqual(true, game.IsFinished);
        }

        [TestMethod]
        // UAT2
        public void When_Token_Is_At_Positon_97_And_Add_4_Should_Not_Move()
        {
            // Arrange
            Game game = new Game();
            game.Players.Add(new Player("Player1"));

            // Act
            game.Players.Find(p => p.Name == "Player1").Position = 97;
            game.Players.Find(p => p.Name == "Player1").MovePlayer(4);
            game.CheckWinCondition();

            // Assert
            Assert.AreEqual(97, game.Players.Find(p => p.Name == "Player1").Position);
            Assert.AreEqual(false, game.IsFinished);
        }

    }
}