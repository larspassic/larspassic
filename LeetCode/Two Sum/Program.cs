using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] solution = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int secondIndex = 0;

                while (nums[i + 1])
                {
                    secondIndex = i + 1;
                }


                if (nums[i] + nums[secondIndex] == target)
                {
                    solution[0] = i;
                    solution[1] = i + 1;
                }
            }

            return solution;
        }
    }
}
