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
            //int[] nums = { 0 };
            int[] nums = { 1, 2, 3 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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
            //Setting up the problem
            IList<IList<int>> result = new List<IList<int>>();

            //Since leetcode says "A subset of an array is a selection of elements (possibly none) of the array."
            //Need to account for "possibly none" by adding currentList immediately in to the result.
            result.Add(new List<int>());
                        

            return result;
            //Copy above here and send to leetcode
        }


    }
}





