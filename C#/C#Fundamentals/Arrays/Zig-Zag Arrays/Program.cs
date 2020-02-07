using System;
using System.Collections.Generic;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> first = new List<int>();
            List<int> second = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    first.Add(arr[0]);
                    second.Add(arr[1]);
                }
                else
                {
                    first.Add(arr[1]);
                    second.Add(arr[0]);
                }
            }
            foreach (var item in first)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in second)
            {
                Console.Write(item + " ");
            }
        }
    }
}
