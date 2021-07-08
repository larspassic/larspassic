using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 3, 4, 5 };

            int target = 9;

           
            int[] solution = TwoSum(nums, target);

            foreach (var item in nums)
            {
                Console.WriteLine($"{item}");
            }

            //Output the result
            Console.WriteLine($"The numbers from that set which add up to {target} are {solution[0]} and {solution[1]}");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            //Outer loop to loop through the elements of the array
            for (int i = 0; i < nums.Length; i++)
            {
                bool resultFound = false;

                //For each element of the array, we walk through and compare the outer element of the array to every other element of the array
                for (int i2 = 0; i2 < nums.Length; i2++)
                {
                    
                    //If i and i2 are going to compare the same index - skip the comparison
                    while (i != i2)
                    {
                        //Check to see if the two numbers work and assign them to the result array
                        if (nums[i] + nums[i2] == target)
                        {
                            result[0] = i;
                            result[1] = i2;

                            resultFound = true;
                        }
                    }

                }

                if (resultFound)
                {
                    break;
                }


            }

            return result;
        }
    }
}
