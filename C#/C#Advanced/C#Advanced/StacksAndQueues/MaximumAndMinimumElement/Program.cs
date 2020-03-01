using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (input[0] == 1)
                {
                    stack.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (input[0] == 3)
                {
                    foreach (var item in stack.OrderByDescending(x => x))
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
                else if (true)
                {
                    foreach (var item in stack.OrderBy(x => x))
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
