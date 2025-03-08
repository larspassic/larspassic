using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test area
            Console.WriteLine("Please enter a roman numeral between 1 and 3999, and it will be converted to a decimal.");
            string userInput = Console.ReadLine();

            //Test input
            userInput = "MCMXCIV";

            //Call the method and send it a string, it will come back as an int
            int result = RomanToInt(userInput);

            //Show the user the result
            Console.WriteLine($"That roman numeral {userInput} displayed as a decimal would be: {result}");
        }

        public static int RomanToInt(string s)
        {
            //Set up the solution. Start with zero
            int solution = 0;

            //Map each roman numeral to it's integer value
            Dictionary<char, int> romanToIntDict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            //Loop
            //Take each letter, look at it's value.
            //Look at the next letter, and it's value.
            //If the next letter is smaller, add the current letter to the value of the solution.
            //If the next letter is larger, subract the current letter from the next letter, and add it to the solution.
            for (int i = 0; i < s.Length; i++)
            {
                //Get current value and store it as an int
                int currentNumeralInt = romanToIntDict[s[i]];

                int nextNumeralInt = 0;

                //Get next value and store it as an int
                //Only update nextNumeralInt if we're not at the end of the string input
                if (i < (s.Length-1))
                {
                    nextNumeralInt = romanToIntDict[s[i + 1]];
                }
                

                if (nextNumeralInt > currentNumeralInt)
                {
                    solution += (nextNumeralInt - currentNumeralInt);
                    //Since we used two numers we need to iterate i past the next number
                    i++;
                }
                else
                {
                    solution += currentNumeralInt;
                }
            }

            //Send the result back.
            return solution;
        }
    }
}
