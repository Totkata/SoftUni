using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = arr[cow];
                }
            }

            int diagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    if (row == cow)
                    {
                        diagonalSum += matrix[row, cow];
                    }
                }
            }

            int reverseDiagonalSum = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    if (row + cow == matrix.GetLength(0) - 1)
                    {
                        reverseDiagonalSum += matrix[row, cow];
                    }
                }
            }

            int difference = Math.Abs(diagonalSum - reverseDiagonalSum);

            Console.WriteLine(difference);
        }
    }
}
