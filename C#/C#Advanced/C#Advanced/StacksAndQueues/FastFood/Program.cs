using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQue = new Queue<int>();

            foreach (var item in orders)
            {
                ordersQue.Enqueue(item);
            }
            foreach (var item in ordersQue.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
                break;
            }
            while (ordersQue.Count != 0 && quantity != 0)
            {
                int order = ordersQue.Peek();
                if (quantity - order >= 0)
                {
                    quantity -= order;
                    ordersQue.Dequeue();
                }
                else
                {
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(" ",ordersQue));
                    return;
                }
            }
            if (ordersQue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
