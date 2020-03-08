using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] matrix = new double[n][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                bool check = false;
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row < n - 1)
                    {
                        if (matrix[row].Length == matrix[row + 1].Length)
                        {
                            matrix[row][col] *= 2;
                            matrix[row + 1][col] *= 2;
                        }
                        else
                        {
                            matrix[row][col] /= 2;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    for (int i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] = matrix[row + 1][i] / 2.0;
                    }
                }
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitedCommand = command.Split(" ").ToArray();

                string cmd = splitedCommand[0];

                int row = int.Parse(splitedCommand[1]);
                int col = int.Parse(splitedCommand[2]);
                int value = int.Parse(splitedCommand[3]);

                if (cmd == "Add" && row >= 0 && col >= 0) 
                {
                    if (matrix.GetLength(0) >= row && matrix[row].Length > col)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (cmd == "Subtract" && row >= 0 && col >= 0)
                {
                    if (matrix.GetLength(0) >= row && matrix[row].Length > col)
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
