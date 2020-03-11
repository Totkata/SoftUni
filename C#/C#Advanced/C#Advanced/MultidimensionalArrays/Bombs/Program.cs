using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            }

            string[] bombs = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] bombIndex = bombs[i].Split(",")
                    .Select(int.Parse).ToArray();
                int rowIndex = bombIndex[0];
                int colIndex = bombIndex[1];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.Length; col++)
                    {
                        if (row == rowIndex && col == colIndex)
                        {
                            int bomb = matrix[row][col];

                            if (bomb > 0)
                            {
                                matrix[row][col] = 0;

                                if (rowIndex + 1 < matrix.GetLength(0))
                                {
                                    if (matrix[row + 1][col] > 0)
                                    {
                                        matrix[row + 1][col] -= bomb;
                                    }
                                }
                                if (rowIndex - 1 >= 0)
                                {
                                    if (matrix[row - 1][col] > 0)
                                    {
                                        matrix[row - 1][col] -= bomb;
                                    }
                                }
                                if (colIndex + 1 < matrix.Length)
                                {
                                    if (matrix[row][col + 1] > 0)
                                    {
                                        matrix[row][col + 1] -= bomb;
                                    }
                                }
                                if (colIndex - 1 >= 0)
                                {
                                    if (matrix[row][col - 1] > 0)
                                    {
                                        matrix[row][col - 1] -= bomb;
                                    }
                                }
                                if (rowIndex - 1 >= 0 && colIndex - 1 >= 0)
                                {
                                    if (matrix[row - 1][col - 1] > 0)
                                    {
                                        matrix[row - 1][col - 1] -= bomb;
                                    }
                                }
                                if (rowIndex + 1 < matrix.GetLength(0) && colIndex + 1 < matrix.Length)
                                {
                                    if (matrix[row + 1][col + 1] > 0)
                                    {
                                        matrix[row + 1][col + 1] -= bomb;
                                    }
                                }
                                if (rowIndex + 1 < matrix.GetLength(0) && colIndex - 1 >= 0)
                                {
                                    if (matrix[row + 1][col - 1] > 0)
                                    {
                                        matrix[row + 1][col - 1] -= bomb;
                                    }
                                }
                                if (colIndex + 1 < matrix.Length && rowIndex - 1 >= 0)
                                {
                                    if (matrix[row - 1][col + 1] > 0)
                                    {
                                        matrix[row - 1][col + 1] -= bomb;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int aliveCellsCount = 0;
            int aliveCellsSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += matrix[row][col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ",matrix[row]));
            }
        }
    }
}
