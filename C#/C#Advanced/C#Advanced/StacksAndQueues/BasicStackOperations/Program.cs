using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int pop = input[1];
            int elementToSearch = input[2];

            int[] secondInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var elementToAdd in secondInput)
            {
                stack.Push(elementToAdd);
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                foreach (var item in stack.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }
    }
}
