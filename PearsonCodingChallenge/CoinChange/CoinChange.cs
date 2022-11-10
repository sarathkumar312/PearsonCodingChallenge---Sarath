using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearsonCodingChallenge
{
    public class CoinChange
    {
        // Driver Code
        public void Main()
        {
            int coinVarieties;
            int[] coinArray = new int[26];
            Console.Write("Enter number of coin possibilities : ");
            coinVarieties = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < coinVarieties; i++)
            {
                coinArray[i] = Console.Read();
                Console.WriteLine(coinArray[i]);
            }
            int changeRequired = 11;
            Console.Write("Minimum coins required is " +
                                 minCoins(coinArray, coinVarieties, changeRequired));
        }

        public int minCoins(int[] coins, int coinVarieties, int changeRequired)
        {

            // base case
            if (changeRequired == 0) 
                return 0;

            // Initialize result
            int res = int.MaxValue;

            // Try every coin that has
            // smaller value than V
            for (int i = 0; i < coinVarieties; i++)
            {
                if (coins[i] <= changeRequired)
                {
                    int sub_res = minCoins(coins, coinVarieties,
                                      changeRequired - coins[i]);

                    // Check for INT_MAX to
                    // avoid overflow and see
                    // if result can minimized
                    if (sub_res != int.MaxValue &&
                                sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }
            return res;
        }
    }
}
