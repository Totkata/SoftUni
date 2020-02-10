using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            int removedSum = 0;
            while (distance.Count() != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int elementToRemove = distance[0];
                    distance[0] = distance.Last();
                    removedSum += elementToRemove;

                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (distance[i] <= elementToRemove)
                        {
                            distance[i] += elementToRemove;
                        }
                        else
                        {
                            distance[i] -= elementToRemove;
                        }
                    }
                }
                else if (index > distance.Count - 1)
                {
                    int elementToRemove = distance.Last();
                    distance[distance.Count() - 1] = distance[0];
                    removedSum += elementToRemove;

                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (distance[i] <= elementToRemove)
                        {
                            distance[i] += elementToRemove;
                        }
                        else
                        {
                            distance[i] -= elementToRemove;
                        }
                    }
                }
                else
                {
                    int elementToRemove = distance[index];

                    distance.RemoveAt(index);
                    removedSum += elementToRemove;

                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (distance[i] <= elementToRemove)
                        {
                            distance[i] += elementToRemove;
                        }
                        else
                        {
                            distance[i] -= elementToRemove;
                        }
                    }
                }

            }
            Console.WriteLine(removedSum);
        }
    }
}
