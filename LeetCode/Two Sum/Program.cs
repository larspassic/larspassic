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
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int secondIndex = 0;

                while ((i + 1) < nums.Length)
                {
                    secondIndex = i + 1;
                }



                if (nums[i] + nums[secondIndex] == target)
                {
                    result[0] = i;
                    result[1] = i + 1;
                }
            }

            return result;
        }
    }
}
