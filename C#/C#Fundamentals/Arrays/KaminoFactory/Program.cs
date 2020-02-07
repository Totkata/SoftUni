using System;
using System.Collections.Generic;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            int[] betsDna = new int[dnaLenght];

            string input = Console.ReadLine();

            int bestIndex = int.MinValue;
            int bestLenght = int.MinValue;
            int count = 0;
            int mostLeft = int.MinValue;

            while (input != "Clone them!")
            {
                int[] dna = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSiqLenght = 0;
                int currentIndex = 0;

                bool check = false;

                count++;

                for (int i = 0; i < dna.Length; i++)
                {

                    if (dna[i] == 1 && check)
                    {
                        currentSiqLenght++;
                    }
                    else if (dna[i] == 1)
                    {
                        currentSiqLenght = 1;
                        currentIndex = i;
                        check = true;
                    }
                    else
                    {
                        if (bestLenght < currentSiqLenght)
                        {
                            bestLenght = currentSiqLenght;
                            bestIndex = currentIndex;
                            betsDna = dna.ToArray();
                            mostLeft = count;
                        }
                        else if (currentSiqLenght == bestLenght && bestIndex > currentIndex)
                        {
                            bestIndex = currentIndex;
                            betsDna = dna.ToArray();
                            mostLeft = count;
                        }
                        else if (currentSiqLenght == bestLenght && bestIndex == currentIndex)
                        {
                            if (dna.Sum() > betsDna.Sum())
                            {
                                bestIndex = currentIndex;
                                betsDna = dna.ToArray();
                                mostLeft = count;
                            }
                        }
                        currentSiqLenght = 0;
                        currentIndex = 0;
                        check = false;
                    }
                    if (bestLenght < currentSiqLenght)
                    {
                        bestLenght = currentSiqLenght;
                        bestIndex = currentIndex;
                        betsDna = dna.ToArray();
                        mostLeft = count;
                    }
                    else if (currentSiqLenght == bestLenght && bestIndex > currentIndex)
                    {
                        bestIndex = currentIndex;
                        betsDna = dna.ToArray();
                        mostLeft = count;
                    }
                    else if (currentSiqLenght == bestLenght && bestIndex == currentIndex)
                    {
                        if (dna.Sum() > betsDna.Sum())
                        {
                            bestIndex = currentIndex;
                            betsDna = dna.ToArray();
                            mostLeft = count;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {mostLeft} with sum: {betsDna.Sum()}.");
            Console.WriteLine(string.Join(" ", betsDna));
        }
    }
}

