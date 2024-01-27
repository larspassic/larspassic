// See https://aka.ms/new-console-template for more information
// Brought in the full template from documentation

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Subsets // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //This will be where we stage the problem for testing here in Visual Studio
            //Instructions from Leetcode:
            /*
             Given an integer array nums of unique elements, return all possible subsets (the power set).

             The solution set must not contain duplicate subsets. Return the solution in any order.
             */


            Console.WriteLine("Hello World!");
            Console.WriteLine("Input:");
            int[] nums = { 1, 2, 3 };

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Result:");
            IList<IList<int>> finalResult = Subsets(nums);

            foreach (var resultItem in finalResult)
            {
                Console.WriteLine(resultItem.ToString());
            }

            Console.WriteLine("All done!");
        }
        
        //This came directly from LeetCode
        public static IList<IList<int>> Subsets(int[] nums)
        {
            //Stuck setting up the problem
            //Just trying to set up an empty object to store the result
            //Fixed this by taking away the I in "IList" after new. I do not know why this works, but I will move forward for now.
            IList<IList<int>> result = new List<IList<int>>();

            //Establish a variable for working with subsets.
            List<int> currentList = new List<int>();

            //Since leetcode says "A subset of an array is a selection of elements (possibly none) of the array."
            //Need to account for "possibly none" by adding currentList immediately in to the result.
            result.Add(currentList.ToList());

            //Outer loop to begin with each element of nums
            for (int i = 0; i < nums.Length; i++)
            {
                //Search the result list and try to add
                if (result.Contains(currentList) == false)
                {
                    result.Add(currentList);
                }

                //Add the current index to the working set
                currentList.Add(nums[i]);

                //Inner loop to go through and add remaining values one at a time
                for (int j = i+1; j < nums.Length; j++)
                {
                    //Re-establish the sub-working-set using the current list
                    List<int> testList = currentList;

                    //Add the next element from the inner loop index
                    testList.Add(nums[j]);

                    //Search the result list and try to add
                    if (result.Contains(testList) == false)
                    {
                        result.Add(testList);
                    }
                }
            }

            

            return result;
            //Copy inside here and send to leetcode
        }


    }
}





