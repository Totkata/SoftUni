using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int countPP = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPP; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                petrolPumps.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                int totalFuel = 0;
                foreach (var currentPP in petrolPumps)
                {
                    int amount = currentPP[0];
                    int distance = currentPP[1];

                    totalFuel += amount - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        startIndex++;
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(startIndex);
        }
    }
}
