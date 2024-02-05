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


            Console.WriteLine("Input:");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] nums = { 1, 2, 3 };
            //int[] nums = { 0 };

            foreach (int i in nums)
            {
                Console.Write(i+",");
            }



            //This section will output the results:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Result:");
            IList<IList<int>> finalResult = Subsets(nums);

            foreach (var resultItem in finalResult)
            {
                //Indicate that this is a new result
                Console.Write("List: ");

                foreach (var item in resultItem)
                {
                    Console.Write(item.ToString()+",");
                }
                
                //Go down to the next line to make the next result look nice.
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("All done!");
        }
        
        //This came directly from LeetCode
        public static IList<IList<int>> Subsets(int[] nums)
        {
            //Stuck setting up the problem
            //Just trying to set up an empty object to store the result
            //Fixed this by taking away the I in "IList" after new. I do not know why this works, but I will move forward for now.
            IList<IList<int>> result = new List<IList<int>>();

            //Since leetcode says "A subset of an array is a selection of elements (possibly none) of the array."
            //Need to account for "possibly none" by adding currentList immediately in to the result.
            result.Add(new List<int>());

            //Outer loop to begin with each element of nums
            for (int i = 0; i < nums.Length; i++)
            {
                //Establish a variable for working with subsets.
                List<int> currentList = new List<int>();


                /*
                //Search the result list and try to add
                if (result.Contains(currentList.ToList()) == false)
                {
                    result.Add(currentList.ToList());
                }
                */

                //Add the current index to the working set
                currentList.Add(nums[i]);
                result.Add(currentList.ToList());
                
                //Inner loop to go through and add remaining values one at a time
                for (int j = i+1; j < nums.Length; j++)
                {
                    //Re-establish the sub-working-set using the current list
                    List<int> testList = currentList;

                    //testList.Add(nums[i]);

                    //Add the next element from the inner loop index
                    testList.Add(nums[j]);

                    //Search the result list and try to add
                    /*
                    if (result.Contains(testList) == false)
                    {
                        result.Add(testList);
                    }
                    */

                    result.Add(testList.ToList());
                }
                
            }

            IList<IList<int>> skipList = new List<IList<int>>();

            //Build up skiplist to be a copy of nums.
            foreach (int num in nums)
            {
                skipList.Add(num);
            }

            //Section to skip numbers in the middle
            for (int k = 0; k < nums.Length; k++)
            {
                
            }

            return result;
            //Copy above here and send to leetcode
        }


    }
}





