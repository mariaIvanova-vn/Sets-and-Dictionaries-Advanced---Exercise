﻿using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!symbols.ContainsKey(item))
                {
                    symbols.Add(item, 1);
                }
                else
                {
                    symbols[item]++;
                }
            }
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
