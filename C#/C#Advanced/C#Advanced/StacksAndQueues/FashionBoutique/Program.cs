using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] box = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var item in box)
            {
                stack.Push(item);
            }

            int rack = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            foreach (var item in stack)
            {
                if (sum + item <= rack)
                {
                    if (count == 0)
                    {
                        count++;
                    }
                    sum += item;
                }
                else
                {
                    sum = item;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
