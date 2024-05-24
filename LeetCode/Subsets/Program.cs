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
            //int[] nums = { 1, 2, 3 };
            //int[] nums = { 1, 2, 3, 4, 5 };
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
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
            // result.Add(new List<int>()); //looks like this is no longer needed due to "binary representation" strategy

            //This section I will find out how many bits are in nums
            int bitCount = nums.Length;

            //This section I will find the total number of possible numbers by multiplying 2^bits
            int totalNumbers = 1;
            for (int i = 0; i < bitCount; i++)
            {
                totalNumbers = totalNumbers * 2;
            }

            //This section I will walk through every possible number by converting that number to binary and storing it as a list
            IList<string> binaryNumbers = new List<string>();

            for (int i = 0; i < totalNumbers; i++)
            {
                //First convert the number to a string using "base 2" aka binary
                //Also, make sure that the number has enough binary digits
                //We should have the same number of binary digits as bitCount
                string binaryString = Convert.ToString(i, 2).PadLeft(bitCount, '0');
                binaryNumbers.Add(binaryString);
            }

            //This section I will walk through every binary value
            for (int i = 0; i < binaryNumbers.Count; i++)
            {
                //Make a list of ints to hold the working subset for this binary number.
                List<int> currentSubset = new List<int>();
                
                //Make a string which is just the number we're working on right now.
                string currentBinary = binaryNumbers[i];

                //Loop through each char of the currentBinary string
                for (int j = 0; j < currentBinary.Length; j++)
                {
                    //Only add the subset from nums if the char from the binary string was 1
                    if (currentBinary[j].ToString() == "1")
                    {
                        currentSubset.Add(nums[j]);
                    }
                    
                    //Do nothing if the char from the binary string was 0
                }

                result.Add(currentSubset);
            }


            return result;
            //Copy above here and send to leetcode
        }


    }
}





