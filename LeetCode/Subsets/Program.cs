// See https://aka.ms/new-console-template for more information
// Brought in the full template from documentation

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] nums = { 1, 2, 3 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int[] nums = { 0 };

            //Testcase that I failed:
            //Expected output: [[],[3],[2],[2,3],[4],[3,4],[2,4],[2,3,4],[1],[1,3],[1,2],[1,2,3],[1,4],[1,3,4],[1,2,4],[1,2,3,4]]
            //int[] nums = { 3, 2, 4, 1 };

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
            //This loop is very "sequential" and does not need any duplicate checking or de-duplication.
            for (int i = 0; i < nums.Length; i++)
            {
                //Establish a variable for working with subsets.
                List<int> currentList = new List<int>();

                //Add the current index to the working set
                currentList.Add(nums[i]);

                //Add the current working set to the result
                result.Add(currentList.ToList());
                
                //Inner loop to go through and add remaining values one at a time
                for (int j = i+1; j < nums.Length; j++)
                {
                    //Re-establish the sub-working-set using the current list
                    List<int> testList = currentList;

                    //testList.Add(nums[i]);

                    //Add the next element from the inner loop index
                    testList.Add(nums[j]);

                    //Add the sub-working-set to the result
                    result.Add(testList.ToList());
                }
                
            }

            // 3/29/2024 - Problem is somewhere below

            
            

            return result;
            //Copy above here and send to leetcode
        }


    }
}





