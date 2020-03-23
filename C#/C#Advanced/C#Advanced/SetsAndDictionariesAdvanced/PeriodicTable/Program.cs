using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new HashSet<string>();
                
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                foreach (var item in input)
                {
                    if (!dict.Contains(item))
                    {
                        dict.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",dict.OrderBy(x => x)));
        }
    }
}
