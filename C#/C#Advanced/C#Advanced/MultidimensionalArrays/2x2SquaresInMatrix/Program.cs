using System;
using System.Linq;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int x = input[0];
            int y = input[1];

            string[,] matrix = new string[x, y];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();

                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = arr[cow];
                }
            }

            int squares = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    if (row + 1 >= matrix.GetLength(0) || cow + 1 >= matrix.GetLength(1))
                    {
                        break;
                    }
                    string leftTop = matrix[row, cow];
                    string rightTop = matrix[row, cow + 1];
                    string leftBot = matrix[row + 1, cow];
                    string rightBot = matrix[row + 1, cow + 1];

                    if (leftTop == rightTop && leftTop == leftBot && leftBot == rightBot)
                    {
                        squares++;
                    }
                }
            }
            Console.WriteLine(squares);
        }
    }
}
