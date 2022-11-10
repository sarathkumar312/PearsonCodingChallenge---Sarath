using NUnit.Framework;

namespace PearsonCodingChallenge
{
    [TestFixture]
    public class CoinChangeTests
    {
        [Test]
        public void CoinChange_ReturnsMinimumCoins_WhenValueEntered()
        {
            //Arrange
            int expectedValue = 6;
            int [] coins = { 1, 2, 5, 10, 20, 50, 100 };
            int coinVarieties = 7;
            int changeRequired = 39;

            //Act
            CoinChange coinChange = new CoinChange();

            //Assert
            Assert.AreEqual(expectedValue, coinChange.minCoins(coins, coinVarieties, changeRequired));
        }
    }
}
