using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqQueryStructure();

            TransformWithSelect();

        }

        private static void TransformWithSelect()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }
        }

        private static void LinqQueryStructure()
        {
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; //Started as int array
            List<int> numbers = new List<int>{ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; //Changed to List

            //The beauty of Linq is that the data source could be either an array or a List, and the query did not need to be changed at all.
            var lowNums = from num in numbers
                          where num < 5
                          select num;


            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }
    }
}
