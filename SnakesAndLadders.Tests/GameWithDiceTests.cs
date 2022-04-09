using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Classes;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class GameWithDiceTests
    {
        [TestMethod]
        // UAT1
        public void Check_Dice_Values()
        {
            // Arrange
            var minValue = 1;
            var maxValue = 6;

            // Act
            var diceResult = Dice.Roll();

            // Assert
            Assert.AreEqual(true, diceResult >= minValue && diceResult <= maxValue);
        }

        [TestMethod]
        // UAT2
        public void When_Dice_Rolls_Token_Moves_Dice_Result_Spaces()
        {
            // Arrange
            Game game = new Game();
            game.Players.Add(new Player("Player1"));

            // Act
            var diceResult = Dice.Roll();
            game.Players.Find(p => p.Name == "Player1").MovePlayer(diceResult);
            game.CheckWinCondition();

            // Assert
            Assert.AreEqual(1+diceResult,game.Players.Find(p => p.Name == "Player1").Position);
        }

    }
}