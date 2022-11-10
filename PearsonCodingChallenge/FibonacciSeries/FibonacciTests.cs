using NUnit.Framework;

namespace PearsonCodingChallenge
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciSeries_WhenEvalutaedWithExpression_ReturnsValue()
        {
            //Arrange
            int firstnumber = 0, secondnumber = 1, counter = 1, input = 6;
            string series = "011235";

            //Act
            FibonacciSeries fibonacSeries = new FibonacciSeries();

            //Assert
            Assert.AreEqual(series, fibonacSeries.FibonaciSeries(firstnumber, secondnumber, counter, input));
        }
    }
}
