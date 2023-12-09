using System;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Staging area for my own testing
            
            //Problem statement:
            //"Given a signed 32-bit integer x, return x with its digits reversed.
            //If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0."

            //Notes
            //I think the reason this is failing is because of negative number inputs,
            //For example, -123 is being reversed to 321- which isn't a number.
            //Now it seems like I assumed "int max value" but in reality it's just some nubmers Leetcode chose.
            //Finally solved it!!!

            bool validNumberReceived = false;

            int userInputInt = 0;

            while (validNumberReceived == false)
            {

                Console.WriteLine($"Please enter an integer to reverse:");

                string userInputString = Console.ReadLine();

                int number;

                bool parseSuccessful = int.TryParse(userInputString, out number);
                if (parseSuccessful == true)
                {
                    userInputInt = number;
                    validNumberReceived = true;
                    //return;
                }
                else
                {
                    Console.WriteLine($"Invalid number received. Next time, enter a valid integer between {int.MinValue} and {int.MaxValue}.\n");
                }

            }

            Solution myClass = new Solution();
            
            int finalResult = myClass.Reverse(userInputInt);

            Console.WriteLine($"The final result was {finalResult}");
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int result = 0;
            
            //Convert x to string
            string normalString = x.ToString();
            
            //Create empty variable for reverse string
            string reversedString = null;

            for (int i = 0; i < normalString.Length; i++)
            {
                reversedString += normalString[normalString.Length - i - 1];
            }

            //Clean up trailing negative signs
            if (reversedString[reversedString.Length - 1] == '-' )
            {
                string newReversedString = "-" ;

                for (int i = 0; i < reversedString.Length - 1; i++)
                {
                    newReversedString += reversedString[i];
                }

                reversedString = newReversedString;
            }

            //Change from validating the result at the end,
            //To instead checking x at the beginning
            //Switch back to checking at the end since that's what needs to get parsed!
            
            //Old way of checking for outside of ranges
            //if ( x <= -2147483648 || x > 2147483647)
            //{
            //    x = 0;
            //    result = x;
            //    return result;
            //}
            
            int number;
            bool parseSuccessful = int.TryParse(reversedString, out number);
            if (parseSuccessful == true)
            {
                //Parse back from string into int
                result = int.Parse(reversedString);

                return result;
            }
            else
            {
                result = 0;
                return 0;
            }


        }
    }
}
