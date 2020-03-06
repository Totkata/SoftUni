using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int r = dementions[0];
            int c = dementions[1];

            string[,] matrix = new string[r, c];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splitedCommand = command.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string swap = splitedCommand[0];
                if (swap == "swap" && splitedCommand.Count() == 5)
                {
                    int row1 = int.Parse(splitedCommand[1]);
                    int col1 = int.Parse(splitedCommand[2]);
                    int row2 = int.Parse(splitedCommand[3]);
                    int col2 = int.Parse(splitedCommand[4]);

                    if (row1 >= 0 && row1 <= r - 1
                        && row2 >= 0 && row2 <= r - 1
                        && col1 >= 0 && col1 <= c - 1
                        && col2 >= 0 && col2 <= c - 1)
                    {
                        string placeOne = matrix[row2, col2];
                        matrix[row2, col2] = matrix[row1, col1];
                        matrix[row1, col1] = placeOne;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                }
            }
        }
    }
}
