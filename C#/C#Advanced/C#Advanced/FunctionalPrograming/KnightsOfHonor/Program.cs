using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> sir = name => Console.WriteLine($"Sir {name}");

            string[] input = Console.ReadLine().Split(" ").ToArray();

            foreach (var item in input)
            {
                sir(item);
            }
        }
    }
}
