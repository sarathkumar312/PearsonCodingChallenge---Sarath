using NUnit.Framework;

namespace PearsonCodingChallenge
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(29)]
        public void RomanNumerals_AssertIfNummbersEnteredAreRomanNumbers(int numbers)
        {
            //Arrange
            string expectedRomanNumber = "XXIX";

           //Act
            Romans romans = new Romans();

            //Assert
            Assert.AreEqual(expectedRomanNumber, romans.int_to_Roman(numbers));
        }
    }
}
