using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            var deviders = Console.ReadLine()
                .Split()
                .Distinct()
                .Select(int.Parse)
                .ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            deviders.ForEach(d => predicates.Add(n => n % d == 0));
            List<int> result = new List<int>();


            for (int i = 1; i <= x; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
