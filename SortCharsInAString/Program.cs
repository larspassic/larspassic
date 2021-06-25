using System;
using System.Collections.Generic;

namespace SortCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "The quick brown fox jumps over the Lazy dog.";

            Console.WriteLine($"{testString}");

            var charList = new List<char>();

            for (int i = 0; i < testString.Length; i++)
            {
                charList.Add(testString[i]);
                Console.WriteLine($"{testString[i]}");
            }



            Console.WriteLine($"Test string: {testString}\n");
            Console.Write($"Char string: ");
            foreach (char item in charList)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            charList.Sort();

            Console.WriteLine("Sorted Char string: ");
            foreach (char item in charList)
            {
                Console.Write($"{item}");
            }

            


        }
    }
}
