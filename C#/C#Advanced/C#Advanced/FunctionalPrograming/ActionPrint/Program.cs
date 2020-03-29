using System;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = line => Console.WriteLine(line);

            string[] input = Console.ReadLine().Split(" ").ToArray();

            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
