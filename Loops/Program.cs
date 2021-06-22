using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge
            //Now that you've seen the if statement and the looping constructs in the C# language,
            //see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3. 

            //So first find the integers (whole numbers)
            //Only in 1-20
            //that are divisible by 3
            //then add them all together

            //Declare a variable to "tally" the sum
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                
                //If i modulus 3 is equal to zero
                //that means that this particular number DID divide evenly by 3
                //because the remainder is zero
                //and return true, and the code block will execute
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }


            }
            
            //Output the result
            Console.WriteLine($"The sum of all numbers from 1 through 20 that divide evenly by 3 is {sum}");
        }
    }
}
