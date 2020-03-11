using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] comands = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string[][] field = new string[n][];

            int[] minerIndex = new int[2];
            int totalCoalCount = 0;

            for (int row = 0; row < n; row++)
            {
                field[row] = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < n; col++)
                {
                    if (field[row][col] == "s")
                    {
                        minerIndex[0] = row;
                        minerIndex[1] = col;
                    }
                    if (field[row][col] == "c")
                    {
                        totalCoalCount++;
                    }
                }
            }

            int coalCOunt = 0;

            int r = minerIndex[0];
            int c = minerIndex[1];

            foreach (var comand in comands)
            {
                if (comand == "up")
                {
                    if (r - 1 >= 0)
                    {
                        field[r][c] = "*";
                        r -= 1;

                        if (field[r][c] == "c")
                        {
                            coalCOunt++;
                            totalCoalCount--;
                        }
                        else if (field[r][c] == "e")
                        {
                            Console.WriteLine($"Game over! ({r}, {c})");
                            return;
                        }
                        field[r][c] = "s";
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (comand == "right")
                {
                    if (c + 1 < n)
                    {
                        field[r][c] = "*";
                        c += 1;

                        if (field[r][c] == "c")
                        {
                            coalCOunt++;
                            totalCoalCount--;
                        }
                        else if (field[r][c] == "e")
                        {
                            Console.WriteLine($"Game over! ({r}, {c})");
                            return;
                        }
                        field[r][c] = "s";
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (comand == "down")
                {
                    if (r + 1 < n)
                    {
                        field[r][c] = "*";
                        r += 1;

                        if (field[r][c] == "c")
                        {
                            coalCOunt++;
                            totalCoalCount--;
                        }
                        else if (field[r][c] == "e")
                        {
                            Console.WriteLine($"Game over! ({r}, {c})");
                            return;
                        }
                        field[r][c] = "s";
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (comand == "left")
                {
                    if (c - 1 >= 0)
                    {
                        field[r][c] = "*";
                        c -= 1;

                        if (field[r][c] == "c")
                        {
                            coalCOunt++;
                            totalCoalCount--;
                        }
                        else if (field[r][c] == "e")
                        {
                            Console.WriteLine($"Game over! ({r}, {c})");
                            return;
                        }
                        field[r][c] = "s";
                    }
                    else
                    {
                        continue;
                    }
                }
                if (totalCoalCount == 0)
                {
                    Console.WriteLine($"You collected all coals! ({r}, {c})");
                    return;
                }
            }
            Console.WriteLine($"{totalCoalCount} coals left. ({r}, {c})");
        }
    }
}