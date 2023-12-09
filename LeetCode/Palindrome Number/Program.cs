namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main is where you stage/prepare the solution
            //Main is handled by Leetcode, so no need to send it back to Leetcode
            //Use main if you want to test multiple example inputs

            //Example 1
            int x = 121;

            //Example 2
            //int x = -121;

            //Example 3
            //int x = 10;

            //Call the function and store the result as a bool
            bool solution = IsPalindrome(x);

            Console.WriteLine(solution);
        }

        //This function which returns a bool was provided by Leetcode
        public static bool IsPalindrome(int x)
        {
            //Paste everything inside THIS function into Leetcode's function to check work or submit

            //Create variables to hold regular and reversed results, as well as bool to send back
            string notReversed;
            string reversed = null;
            bool result;

            //Convert x from integer in to a string
            notReversed = x.ToString();

            //Flip notReversed and store it in reversed
            for (int i = 0; i < notReversed.Length; i++)
            {
                //Assign one single index of reversed, using an index from notReversed
                reversed += notReversed[notReversed.Length - i - 1];
            }

            //Compare regular and reversed variables
            //If they are the same, return true because Palindrome
            if (reversed == notReversed)
            {
                result = true;
            }
            
            //If they are not the same, return false because not Palindrome
            else
            {
                result = false;
            }

            //Send the bool result back
            return result;
        }
    }
}