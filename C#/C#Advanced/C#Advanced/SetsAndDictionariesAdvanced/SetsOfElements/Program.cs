using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            for (int i = 0; i < nm[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());

                set1.Add(input);
                
            }
            for (int i = 0; i < nm[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set2.Add(input);
            }
            var output = new HashSet<int>();
            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    output.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
