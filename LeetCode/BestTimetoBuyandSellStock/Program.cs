namespace BestTimetoBuyandSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            /*
            Example 1:
            Input: prices = [7,1,5,3,6,4]
            Output: 5
            Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
            
            Example 2:
            Input: prices = [7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transactions are done and the max profit = 0.
            */

            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            int solution = MaxProfit(prices);
        }

        public static int MaxProfit(int[] prices)
        {
            //Set up the variable to store the result.
            int result = 0;

            //Set up a variable called "highestProfit" 

            //Loop through prices array

            //Subtract i+1 from i

            //Store the result in highestProfit

            //If the result is negative, or smaller than highestProfit, do nothing. Leave highestProfit as is.

            //If the result is higher than highestProfit, replace highestProfit with current result


            //Send the result back.
            return result;
        }
    }
}