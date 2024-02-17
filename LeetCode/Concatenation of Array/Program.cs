namespace Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = [1, 2, 1];
            var ans = GetConcatenation;
        }

        public static int[] GetConcatenation(int[] nums)
        {
            //Create a variable that will store the result
            int[] result = new int[(nums.Length*2)];

            //Create some variables to use inside the for loop
            bool hasConcatenated = false;
            int resultIndex = 0;

            //Loop through 
            for (int i = 0; i < result.Length; i++)
            {
                //Check to see if i is already at the end
                if (i == nums.Length)
                {
                    //Reset i to 0
                    i = 0;
                    
                    //Keep track of if we've done this
                    hasConcatenated = true;
                }

                //Store each result
                result[resultIndex] = nums[i];

                //Iterate the result index
                resultIndex++;

                if (resultIndex == result.Length)
                {
                    break;
                }
            }

            //Send the result back
            return result;
        }
    }
}
