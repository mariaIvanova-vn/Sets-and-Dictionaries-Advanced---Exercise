using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string color=input.Split(" -> ")[0];
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }
                Dictionary<string, int> clothes = dict[color];
                string[] inputClothes = input.Split(" -> ")[1].Split(",");

                foreach (var item in inputClothes)
                {
                    if (!clothes.ContainsKey(item))
                    {
                        clothes.Add(item, 1);
                    }
                    else { clothes[item]++; }   
                }
            }
            string searchItem = Console.ReadLine();
            string searchColor = searchItem.Split()[0];
            string searchCloth=searchItem.Split()[1];

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                Dictionary<string, int> clothes = item.Value;
                foreach (var cloth in clothes)
                {
                    if (cloth.Key==searchCloth && item.Key==searchColor)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
