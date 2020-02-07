using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Do_Not_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            int removedSum = 0;
            while (pokemons.Count() != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int elementToRemove = pokemons[0];
                    pokemons[0] = pokemons.Last();
                    removedSum += elementToRemove;

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= elementToRemove)
                        {
                            pokemons[i] += elementToRemove;
                        }
                        else
                        {
                            pokemons[i] -= elementToRemove;
                        }
                    }
                }
                else if (index > pokemons.Count - 1)
                {
                    int elementToRemove = pokemons.Last();
                    pokemons[pokemons.Count() - 1] = pokemons[0];
                    removedSum += elementToRemove;

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= elementToRemove)
                        {
                            pokemons[i] += elementToRemove;
                        }
                        else
                        {
                            pokemons[i] -= elementToRemove;
                        }
                    }
                }
                else
                {
                    int elementToRemove = pokemons[index];

                    pokemons.RemoveAt(index);
                    removedSum += elementToRemove;

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= elementToRemove)
                        {
                            pokemons[i] += elementToRemove;
                        }
                        else
                        {
                            pokemons[i] -= elementToRemove;
                        }
                    }
                }

            }
            Console.WriteLine(removedSum);
        }
    }
}
