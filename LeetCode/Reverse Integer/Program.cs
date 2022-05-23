using System;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    return;
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

            string normalString = x.ToString();

            string reversedString = null;

            for (int i = 1; i <= normalString.Length; i++)
            {
                reversedString += normalString[normalString.Length - i];
            }

            result = int.Parse(reversedString);

            if (result > int.MaxValue || result < int.MinValue)
            {
                result = 0;
            }
            
            return result;
        }
    }
}
