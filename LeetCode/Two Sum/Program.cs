using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] nums = new int[] { 2, 7, 11, 15 }; //example 1
            //int target = 26; //example 1

            //int[] nums = new int[] { 3, 2, 4 }; //example 2
            //int target = 6; //example 2

            //int[] nums = new int[] { 3, 3 }; //example 3
            //int target = 6; //example 3

            int[] nums = new int[] { -3, 4, 3, 90 }; //example 4
            int target = 0; //example 4

            int[] solution = TwoSum(nums, target);

            foreach (var item in nums)
            {
                Console.WriteLine($"{item}");
            }

            //Output the result
            Console.WriteLine($"The indices from that set which add up to {target} are {solution[0]} and {solution[1]}");

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            bool resultFound = false;

            //Outer loop to loop through the elements of the array
            for (int i = 0; i < nums.Length; i++)
            {
                

                //Inner loop to compare each item to the one in front of it and every other item
                for (int i2 = i + 1; i2 < nums.Length; i2++)
                {

                    
                    //Check to see if the two numbers equal the target, and assign them to the result array
                    if (nums[i] + nums[i2] == target)
                    {
                        result[0] = i;
                        result[1] = i2;

                        resultFound = true;
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
