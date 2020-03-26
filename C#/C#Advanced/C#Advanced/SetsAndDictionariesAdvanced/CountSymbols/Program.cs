using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();

            var set = new SortedDictionary<char, int>();

            foreach (var item in arr)
            {
                if (set.ContainsKey(item))
                {
                    set[item]++;
                }
                else
                {
                    set.Add(item, 1);
                }
            }
            foreach (var item in set.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
