using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBotles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cup = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] botle = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>();
            foreach (var item in cup)
            {
                cups.Enqueue(item);
            }

            Stack<int> botles = new Stack<int>();
            foreach (var item in botle)
            {
                botles.Push(item);
            }

            int wastedWater = 0;

            while (botles.Count() != 0 && cups.Count() !=0)
            {
                int currBotle = botles.Peek();
                int currCup = cups.Peek();

                if (currCup - currBotle <= 0)
                {
                    wastedWater += currBotle - currCup;

                    botles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    while (currCup > 0)
                    {
                        if (currCup - currBotle <= 0)
                        {
                            wastedWater += currBotle - currCup;
                            botles.Pop();
                            cups.Dequeue();
                            break;
                        }
                        currCup -= currBotle;
                        botles.Pop();
                        currBotle = botles.Peek();
                    }
                }
            }
            if (cups.Count() == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ",botles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
