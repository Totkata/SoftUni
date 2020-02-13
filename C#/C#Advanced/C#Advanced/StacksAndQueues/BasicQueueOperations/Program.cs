using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
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
            int dequeue = input[1];
            int elementToSearch = input[2];

            int[] secondInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> que = new Queue<int>();

            foreach (var item in secondInput)
            {
                que.Enqueue(item);
            }
            for (int i = 0; i < dequeue; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (que.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                foreach (var item in que.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }
    }
}
