using System;

namespace Unique_Paths
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int m = 3;

            int n = 7;


            int solution = UniquePaths(m, n);

            Console.WriteLine($"The number of unique paths for a grid of {m} rows and {n} columns is: {solution}");

        }

        public static int UniquePaths(int m, int n)
        {
            int result = new int();

            int[,] dp = new int[m, n];

            //Loop to fill the top row with 1s
            for (int i = 0; i < n; i++)
            {
                //Assign a 1 to this location.
                dp[0, i] = 1;
            }

            //Loop to fill the left column with 1s
            for (int j = 0; j < m; j++)
            {
                //Assign a 1 to this location.
                dp[j,0] = 1;
            }

            //Now the dp has been filled in with 1s in teh first rows.

            //Nested for loops to fill in the rest of the table.
            
            //Sticking with what I did above, do the rows in the outer loop
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    //The crux of the algorithm
                    //The number of ways to get to a cell
                    //Is the same as adding together
                    //The cells above and to the left of it
                    dp[j, i] = dp[j,i-1] + dp[j-1,i];
                }
            }


            result = dp[m-1, n-1];

            return result;
        }
    }


}
