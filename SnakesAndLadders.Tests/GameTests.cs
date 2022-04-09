using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        // UAT1
        public void When_game_starts_token_position_is_1()
        {
            // Arrange
            Player player1 = new Player("Player1");

            // Act
            player1.Position = 1;

            // Assert
            Assert.AreEqual(1, player1.Position);
        }

        [TestMethod]
        // UAT2
        public void When_Token_Moves_3_Final_Position_Should_Be_4()
        {
            // Arrange
            Player player1 = new Player("Player1");

            // Act
            player1.MovePlayer(3);

            // Assert
            Assert.AreEqual(4, player1.Position);
        }

        [TestMethod]
        // UAT3
        public void When_Token_Moves_3_Then_4_Final_Position_Should_Be_8()
        {
            // Arrange
            Player player1 = new Player("Player1");

            // Act
            player1.MovePlayer(3);
            player1.MovePlayer(4);

            // Assert
            Assert.AreEqual(8, player1.Position);
        }
    }
}