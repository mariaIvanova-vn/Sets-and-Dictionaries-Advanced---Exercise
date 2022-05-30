using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            SortedSet<string>  set=new SortedSet<string>(); 
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                for (int j = 0; j < commands.Length; j++)
                {
                    set.Add(commands[j]);   
                }              
            }
            Console.WriteLine(string.Join(" ",set)); 
        }
    }
}
