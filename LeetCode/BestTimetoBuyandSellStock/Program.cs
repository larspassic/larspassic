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

            int[] prices = new int[] { 2, 1, 4 };

            int solution = MaxProfit(prices);

            Console.WriteLine(solution);
        }

        public static int MaxProfit(int[] prices)
        {
            //Set up the variable to store the result.
            int result = 0;

            //Set up a variable to store the currently highest profit
            int highestProfit = 0;
            
            //Set up a variable to keep track of the lowest possible buy price.
            //If a better profit happened previously, then highestProfit should already have it.
            int lowestBuyPrice = prices[0];
            
            
            //Loop through prices array
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int subtractionResult = new int();

                //Since we found a new lowestBuyPrice
                if (prices[i] < lowestBuyPrice)
                {
                    //Set the new lowestBuyPrice
                    lowestBuyPrice = prices[i];

                    //Since this sale will be a loss - skip this iteration of the loop //Note: my logic here was flawed.
                    //continue; //This broke a test case so commenting it out.
                }

                //Perform the math to get current iteration's profit
                subtractionResult = prices[i+1] - lowestBuyPrice;

                //Check to see if we have found a new high profit, and if so, store the result
                if (subtractionResult > highestProfit)
                {
                    highestProfit = subtractionResult;
                }

            }

            //At the very end, assign highestProfit to result
            result = highestProfit;


            //Send the result back.
            return result;
        }
    }
}