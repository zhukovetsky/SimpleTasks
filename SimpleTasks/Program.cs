﻿using System;
using System.Linq;

namespace SimpleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;

            while (alive)
            {
                Console.WriteLine("Please enter 5 random digits:");
                string inputStr = Console.ReadLine();
                int result;

                if (!int.TryParse(inputStr, out result))
                {
                    Console.WriteLine("Input must be digits!");
                    continue;
                }

                if (inputStr.Length < 5)
                {
                    Console.WriteLine("Input must containe 5 digits");
                    continue;
                }

                foreach (char c in inputStr.Substring(0, 5))
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("Do you want to continue, 'Enter' to continue, 'Esc' - to finish");
                ConsoleKeyInfo key = Console.ReadKey();

                if (ConsoleKey.Escape.Equals(key.Key))
                {
                    alive = false;
                }
            }
        }
    }
}
