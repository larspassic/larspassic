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

            Console.WriteLine(solution);
        }

        public static int MaxProfit(int[] prices)
        {
            //Set up the variable to store the result.
            int result = 0;

            //Set up a variable called "highestProfit" 
            int highestProfit = 0;
            
            
            //Loop through prices array
            for (int i = 0; i < prices.Length; i++)
            {
                int subtractionResult = new int();

                for (int j = i+1; j < prices.Length; j++)
                {
                    //If j is less than or equal to i, use continue to skip to the next iteration of the 'j' for loop.
                    //This will help prevent selling stocks in the past.
                    //What if I just assign j to be i+1 so I don't have to keep continuing past wasteful iterations?
                    /*
                    if (j <= i)
                    {
                        continue;
                    }
                    */

                    //Trying to speed this up by doing some testing prior to storing the result in subtractionResult.
                    //If the sell date has a lower price than the buy date, going to be a loss, skip the whole loop.
                    if (prices[j] <= prices[i])
                    {
                        continue;
                    }

                    //Subtract j from i    //This is resulting in "buy high and sell low" results. Will need to fix.
                    subtractionResult = prices[j] - prices[i];

                    //If the result is negative, or smaller than highestProfit, do nothing. Leave highestProfit as is.
                    //Since I have eliminated losses above,
                    //and I am implicitly filtering out values that are lower than highestProfit below,
                    //I will try to comment this section out completely to save processing time.

                    /*
                    if (subtractionResult < 0 || subtractionResult < highestProfit)
                    {
                        //Use the continue keyword to skip the remainder of this 'j' for loop iteration
                        continue;
                    }
                    */

                    //If the result is higher than highestProfit, replace highestProfit with current result
                    if (subtractionResult > highestProfit)
                    {
                        highestProfit = subtractionResult;
                    }

                }

            }

            //At the very end, assign highestProfit to result
            result = highestProfit;


            //Send the result back.
            return result;
        }
    }
}