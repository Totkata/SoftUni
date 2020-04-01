using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new List<string>();
            arr.Where(n => n.Length <= lenght)
                .ToList()
                .ForEach(result.Add);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
