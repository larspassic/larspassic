namespace Find_the_Maximum_Achievable_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find the \"Maximum Achievable Number\"\n" );

            //Declare inputs
            int num = 500;
            int t = 50;

            //Send inputs in to the function and store as result
            int result = TheMaximumAchievableX(num, t);

            //Output result to user
            Console.WriteLine("The maximum achievable number is: " + result);
        }

        public static int TheMaximumAchievableX(int num, int t)
        {
            int maxAchievableNumber = 0;

            //////////////////
            //plusPlus section
            //////////////////
            //Leetcode states that num will never be a negative number (num >= 1)
            //So no reason to do a bunch of logic here
            //This case is for when x == num because +1 and +1 will always result in an achievable number.
            //So max achievable number is always num
            //So just store num as a max achievable number.

            //Just need to protect for the special case where num is the largest integer
            if (num < (int.MaxValue))
            {
                maxAchievableNumber = num;
            }

            //////////////////
            //minusMinus section
            //////////////////
            //This section should have the same principle has the plusPlus section
            //Even if x == num and num == 1 then we can still -1 and -1 and still find an equal number.
            //But we have already covered the x == num use-case above in the plusPlus section,
            //So no code is needed here.

            //////////////////
            //plusMinus section
            //////////////////
            //This section is where num is lower than x
            //So x will be t x 2 steps away from num
            int maxDistance = t * 2;
            
            //Need to protect for the case where num + (t x 2) goes over the max int value
            //So if that is the case, just store the int max value as max achievable number
            if (num+maxDistance > int.MaxValue)
            {
                maxAchievableNumber = int.MaxValue;
            }
            //If the current max number is smaller
            else if (maxAchievableNumber < num + maxDistance)
            {
                //Then store the result
                maxAchievableNumber = num + maxDistance;
            }
             

            //////////////////
            //minusPlus section
            //////////////////
            //In this case, num is always higher than x
            //Since we're looking for the largest POSITIVE numbers
            //The largest number in this case is always num-2
            //Because x did +1 and num did -1
            //And that will be the least small possible value for x

            //Only store this value if num-2 is larger
            if (maxAchievableNumber < (num-2))
            {
                //Store the result
                maxAchievableNumber = num - 2;
            }

            return maxAchievableNumber;
        }
    }
}
