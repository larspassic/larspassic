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
            int x = 0;

            bool boolPlusPlusMatchFound = false;
            bool boolPlusMinusMatchFound = false;
            bool boolMinusPlusMatchFound = false;
            bool boolMinusMinusMatchFound = false;

            //Encapsulate all possibilities in a huge loop to keep iterating until something is found.
            //The leetcode instructions say that there will always be a result.
            while (x <= int.MaxValue)
            {


                //////////////////
                //plusPlus section
                //////////////////
                int plusPlusnum = num;
                int plusPlusX = x;

                //Code which executes the wishes of "t"
                for (int i = 0; i < t; i++)
                {
                    plusPlusnum++;
                    plusPlusX++;

                    //Always check if the two numbers are equal. That's what we want.
                    if (plusPlusX == plusPlusnum)
                    {
                        break;
                    }
                }

                //If we got to the end and found a match 
                if (plusPlusX == plusPlusnum)
                {
                    //AND the x number is larger than the current max achievable number
                    if (x > maxAchievableNumber)
                    {
                        //Store the new max achievable number
                        maxAchievableNumber = x;
                        boolPlusPlusMatchFound = true;
                    }
                }

                //////////////////
                //plusMinus section
                //////////////////
                int plusMinusnum = num;
                int plusMinusX = x;

                //Code which executes the wishes of "t"
                for (int i = 0; i < t; i++)
                {
                    plusMinusnum++;
                    plusMinusX--;

                    //Always check if the two numbers are equal. That's what we want.
                    if (plusMinusX == plusMinusnum)
                    {
                        break;
                    }
                }

                //If we got to the end and found a match 
                if (plusMinusX == plusMinusnum)
                {
                    //AND the x number is larger than the current max achievable number
                    if (x > maxAchievableNumber)
                    {
                        //Store the new max achievable number
                        maxAchievableNumber = x;
                        boolPlusMinusMatchFound = true;
                    }
                }

                //////////////////
                //minusPlus section
                //////////////////
                int minusPlusnum = num;
                int minusPlusX = x;

                //code which executes the wishes of "t"
                for (int i = 0; i < t; i++)
                {
                    minusPlusnum--;
                    minusPlusX++;

                    //Always check if the two numbers are equal.
                    if (minusPlusX == minusPlusnum)
                    {
                        break;
                    }
                }

                //If we got to the end and found a match
                if (minusPlusX == minusPlusnum)
                {
                    //And if the x variable we were using is larger than the current max
                    if (x > maxAchievableNumber)
                    {
                        //Store the new max achievable number
                        maxAchievableNumber = x;
                        boolMinusPlusMatchFound = true;
                    }
                }

                //////////////////
                //minusMinus section
                //////////////////
                int minusMinusnum = num;
                int minusMinusX = x;

                //code which executes the wishes of "t"
                for (int i = 0; i < t; i++)
                {
                    minusMinusnum--;
                    minusMinusX--;

                    //Check to see if we found a match
                    if (minusMinusnum == minusMinusX)
                    {
                        break;
                    }
                }

                //If we got to the end nad found a match
                if (minusMinusX == minusMinusnum)
                {
                    //And the x variable is larger than the current max
                    if (x > maxAchievableNumber)
                    {
                        //Store the new max achievable number
                        maxAchievableNumber = x;
                        boolMinusMinusMatchFound = true;
                    }
                }
                
                //Iterate the starting number for the large while loop
                x++;
            }

            return maxAchievableNumber;
        }
    }
}
