using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character sequence to try some ciphers:");
            string userInput = Console.ReadLine();

            Console.Write("Enter the number of iterations you want to try:");
            int userInputInt = Convert.ToInt32(Console.ReadLine());

            string inputString = userInput;

            //Call the method the number of times you want to shift up
            for (int i = 1; i <= userInputInt; i++)
            {
                //Shift the chars in the string by calling the method
                string shiftedOutput = TryCiphers(inputString);

                //Display the results
                Console.WriteLine("When shifting by " + i + " the output is: " + shiftedOutput);

                //Now set the output as the next input
                inputString = shiftedOutput;
            }


        }

        private static string TryCiphers(string userInput)
        {
            char[] shiftedChars = new char[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                char c = userInput[i];

                //Only do this section if it's a real letter
                if (char.IsLetter(c))
                {
                    //If it's lowercase z move it to lowercase a
                    if (c == 'z')
                    {
                        shiftedChars[i] = 'a';
                    }
                    //If it's uppercase Z move it to uppercase A
                    else if (c == 'Z')
                    {
                        shiftedChars[i] = 'A';
                    }
                    //Otherwise just move it up one char
                    else
                    {
                        shiftedChars[i] = (char)(c + 1);
                    }
                }
                else
                {
                    shiftedChars[i] = c;
                }
            }

            return new string(shiftedChars);
        }
    }
}
