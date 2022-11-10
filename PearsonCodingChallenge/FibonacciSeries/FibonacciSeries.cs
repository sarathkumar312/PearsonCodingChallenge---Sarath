using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonCodingChallenge
{
    public class FibonacciSeries
    {
        public void Main()
        {
            Console.WriteLine("Please enter the Length of the Fibonacci Series : ");
            int input = int.Parse(Console.ReadLine());
            FibonaciSeries(0, 1, 1, input);
        }

        public string FibonaciSeries(int firstNumber, int secondNumber, int counter, int input)
        {
            string series = firstNumber + "";
            if (counter < input)
            {
                FibonaciSeries(secondNumber, firstNumber + secondNumber, counter + 1, input);
            }
            return series;
        }
    }
}
