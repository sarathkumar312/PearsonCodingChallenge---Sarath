using NUnit.Framework;

namespace PearsonCodingChallenge
{
    [TestFixture]
    public class PalindromeTests
    {
        [TestCase("noon")]
        [TestCase("madam")]
        public void PalindromeTest_ReturnsPalindrome_AccordingToString(string palindromeString)
        {
            //Act
            Palindrome palindrome = new Palindrome();

            //Assert
            Assert.AreEqual(true, palindrome.getStatus(palindromeString));
        }

        [TestCase("pearson")]
        [TestCase("enough")]
        public void PalindromeTest_ReturnsNotPalindrome_AccordingToString(string palindromeString)
        {
            //Act
            Palindrome palindrome = new Palindrome();

            //Assert
            Assert.AreNotEqual(true, palindrome.getStatus(palindromeString));
        }
    }
}
