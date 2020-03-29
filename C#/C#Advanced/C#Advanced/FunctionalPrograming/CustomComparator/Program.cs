using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = new List<int>();


            arr.Where(n => n % 2 == 0).OrderBy(x => x)
                .ToList()
                .ForEach(result.Add);
            arr.Where(n => n % 2 != 0).OrderBy(x => x)
               .ToList()
               .ForEach(result.Add);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
