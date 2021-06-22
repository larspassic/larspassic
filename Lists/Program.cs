using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("\nLet's show the array as it is.\n");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nWe will now sort the array.\n");

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
