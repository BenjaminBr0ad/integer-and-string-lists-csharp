using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListsAndStrings();
            ListsAndIntegers(20);
        }

        public static void ListsAndIntegers(int num)
        {
            var fibonacciNumbers = new List<int> {1,1};

            

            // for (var i = 2; i < num; i++)
            // {
            //     fibonacciNumbers.Add(previous + previous2);
            //     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            // }

            // foreach (var number in fibonacciNumbers)
            // {
            //     System.Console.WriteLine(number);
            // }

            // ---- OR -----

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var number in fibonacciNumbers)
            {
                System.Console.WriteLine(number);
            }

        }

        public static void ListsAndStrings()
        {
            var names = new List<string> { "Ben", "Ana", "Felipe" };
            
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            // Inserts a blank line
            System.Console.WriteLine();

            names.Add("Jeff");
            names.Add("Peter");
            names.Remove("Ana");

            System.Console.WriteLine();

            foreach (var name in names)
            {
                System.Console.WriteLine($"Hey there {name.ToUpper()}!");
            }

            // Indexed like Javascript
            System.Console.WriteLine($"The first name in the list is {names[0]}");

            // .Count()
            System.Console.WriteLine($"There are {names.Count} names in the list.");

            // .IndexOf()
            var index = names.IndexOf("Ben");
            if (index == -1)
            {
                System.Console.WriteLine($"When an item is not found, IndexOf returns an index value of {index}.");
            }
            else
            {
                System.Console.WriteLine($"When an item is found, IndexOf returns the index of that item in the list: {names[index]}: @ {index}.");
            }

            index = names.IndexOf("NotFound");
            if (index == -1)
            {
                System.Console.WriteLine($"When an item is not found, IndexOf returns an index value of {index}.");
            }
            else
            {
                System.Console.WriteLine($"When an item is found, IndexOf returns the index of that item in the list: {names[index]}: @ {index}.");
            }

            // .Sort()
            names.Sort();
            foreach (var name in names)
            {
                System.Console.WriteLine(name);
            }

        }
    }
}