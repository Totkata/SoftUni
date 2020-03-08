using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            string[,] matrix = new string[n,m];

            string input = Console.ReadLine();

            Queue<char> fill = new Queue<char>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                while (fill.Count < m)
                {
                    foreach (var item in input)
                    {
                        fill.Enqueue(item);
                    }
                }

                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = fill.Peek().ToString();
                        fill.Dequeue();
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = fill.Peek().ToString();
                        fill.Dequeue();
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
