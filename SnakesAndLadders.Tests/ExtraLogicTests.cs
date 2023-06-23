using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Classes;
using System.Linq;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class ExtraLogicTests
    {
        [TestMethod]
        // Testing Snake Behaviour
        public void When_Token_Steps_On_Snake_Goes_Back_To_Snakes_Tail()
        {
            // Arrange
            Game game = new Game();
            game.Players.Add(new Player("player1"));

            // Act
            game.Players.FirstOrDefault(p => p.Name == "player1").Position = 16;
            game.CheckSnakesAndLadders(game.Players.FirstOrDefault(p => p.Name == "player1"));

            // Assert
            Assert.AreEqual(6, game.Players.FirstOrDefault(p => p.Name == "player1").Position);
        }

        [TestMethod]
        // Testing Ladder Behaviour
        public void When_Token_Steps_On_Ladder_Climbs_To_Its_Top()
        {
            // Arrange
            Game game = new Game();
            game.Players.Add(new Player("player1"));

            // Act
            game.Players.FirstOrDefault(p => p.Name == "player1").Position = 2;
            game.CheckSnakesAndLadders(game.Players.FirstOrDefault(p => p.Name == "player1"));

            // Assert
            Assert.AreEqual(38, game.Players.FirstOrDefault(p => p.Name == "player1").Position);
        }

    }
}