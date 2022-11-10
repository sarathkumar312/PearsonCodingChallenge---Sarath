using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonCodingChallenge
{
    using System;

    public class Palindrome
    {
        //public static void Main()
        //{
        //    string palindRomeString = Console.ReadLine();
        //    bool x = getStatus(palindRomeString);
        //    Console.WriteLine(x);
        //}

        public bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
