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
            Console.WriteLine("Hello World!");

            int[] nums = { 1, 2, 3};

            Console.WriteLine(nums);
        }
    }

    //Do I need this?
    public interface IList
    {

    }

    public class Solution
    {
        //This came directly from LeetCode
        public IList<IList<int>> Subsets(int[] nums)
        {
            //Stuck setting up the problem
            //Just trying to set up an empty object to store the result
            IList<IList<int>>  result = new IList<IList<int>>;

            return result;
        }
    }
}
