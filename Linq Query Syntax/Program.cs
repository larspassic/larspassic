using System;
using System.Collections.Generic;
using System.Linq;

//Samples from C# 201 youtube series

namespace Linq_Query_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //TakeElements();

            //NestedTakePartitions();

            //TakeWhileSyntax();

            //CompareTwoSequencesForEquality();

            //CombineSequencesWithZip();

            //SelectFromMultipleInputSequences();

            //QueriesExecuteLazily();

            //RequestEagerQueryExecution();

            ReuseQueriesWithNewResults();
        }

        private static void ReuseQueriesWithNewResults()
        {
            // Deferred execution lets us define a query once
            // and then reuse it later after data changes.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNumbers = from n in numbers
                             where n <= 3
                             select n;

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }

            // During this second run, the same query object,
            // lowNumbers, will be iterating over the new state
            // of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }
        }

        private static void RequestEagerQueryExecution()
        {
            // Methods like ToList() cause the query to be
            // executed immediately, caching the results.

            Console.WriteLine("Request eager query execution");

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = (from n in numbers
                     select ++i)
                     .ToList();

            // The local variable i has already been fully
            // incremented before we iterate the results:
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
        }

        private static void QueriesExecuteLazily()
        {
            // Sequence operators form first-class queries that
            // are not executed until you enumerate over them.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = from n in numbers
                    select ++i;

            // Note, the local variable 'i' is not incremented
            // until each element is evaluated (as a side-effect):
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
        }

        private static void SelectFromMultipleInputSequences()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }
        }

        private static void CombineSequencesWithZip()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();

            Console.WriteLine($"Dot product: {dotProduct}");
        }

        private static void CompareTwoSequencesForEquality()
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            //var wordsB = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "apple", "blueberry", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine($"The sequences match: {match}");
        }

        private static void TakeWhileSyntax()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
        }

        private static void NestedTakePartitions()
        {
            //List<Customer> customers = GetCustomerList();

            //var first3WAOrders = (
            //    from cust in customers
            //    from order in cust.Orders
            //    where cust.Region == "WA"
            //    select (cust.CustomerID, order.OrderID, order.OrderDate))
            //    .Take(3);

            //Console.WriteLine("First 3 orders in WA:");
            //foreach (var order in first3WAOrders)
            //{
            //    Console.WriteLine(order);
            //}
        }

        private static void TakeElements()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
