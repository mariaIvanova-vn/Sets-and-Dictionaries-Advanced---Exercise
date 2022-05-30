using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m=input[1]; 

            HashSet<int> firstSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);  
            }
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num); 
            }
            HashSet<int> result = new HashSet<int>();
            
            foreach (var item in firstSet)
            {
                foreach (var item2 in secondSet)
                {
                    if (item==item2)
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
