using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //WorkWithStringsIMadeThis();

            //WorkWithStringsFromDocs();

            WorkWithOtherTypes();
        }

        public static void WorkWithStringsIMadeThis()
        {



            //var is what you put when you do not know what this variable is going to be
            //var is a "code style" thing
            //List<string> is called "generics"
            //Pronounced "List of type string" //Cup<T> = "Cup of type tea"
            var names = new List<string> { "New Friend", "Rebecca", "Violet" };

            //foreach uses a variable instead of iterators and indexers
            //helpful when you just want to get through the whole list
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            names.Add("John");
            names.Add("Mary");
            names.Add("Lars");

            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }

            //Csharp is zero-indexed
            //The zeroeth spot is the first spot
            //When you are indexing with the square brackets
            //it is pronounced "names at zero"
            //Console.WriteLine(names[0]);


            var index = names.IndexOf("Mary");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            //Sorting

            Console.WriteLine("\nLet's show the list as it is.\n");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nWe will now sort the list.\n");

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void WorkWithStringsFromDocs()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        public static void WorkWithOtherTypes()
        {
            //Create the list of ints
            var fibonacciNumbers = new List<int> { 1, 1 };


            //for (int i = 0; i < 18; i++) //this was my guess
            while (fibonacciNumbers.Count < 20) //this one is better!
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
