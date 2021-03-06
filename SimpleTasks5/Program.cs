﻿using System;
using System.Linq;

namespace SimpleTasks5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char searchedChar;

            Console.WriteLine("Enter your string:");
            str = Console.ReadLine();

            Console.WriteLine("Enter searched char:");
            searchedChar = Console.ReadKey().KeyChar;

            Console.WriteLine();

            int result = str.ToLower().AsEnumerable().Count(c => c.Equals(searchedChar));
            Console.WriteLine($"You have entered '{searchedChar}', and {searchedChar} appeared in sequence {result} times");

        }
    }
}
