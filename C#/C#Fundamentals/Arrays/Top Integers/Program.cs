using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool isTopInteger = false;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        isTopInteger = true;
                    }
                    else
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(input[i] + " ");
                }
            }
            Console.WriteLine(input[input.Length - 1]);
        }
    }
}
