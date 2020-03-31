using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        private static object result;

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Predicate<int> calculation = x => x % 2 == 0;

            List<int> result = new List<int>();

            Enumerable.Range(input[0], input[1] - input[0] + 1)
               .Where(x => command == "even" ? calculation(x) : !calculation(x))
               .ToList()
               .ForEach(result.Add);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
