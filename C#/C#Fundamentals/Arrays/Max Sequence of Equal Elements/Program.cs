using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstIndex = 0;
            int count = 0;
            int num = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int newCount = 0;
                if (input[i] == input[i + 1])
                {
                    for (int j = i; j < input.Length - 1; j++)
                    {
                        if (input[j] == input[j+1])
                        {
                            newCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (newCount > count)
                {
                    firstIndex = i;
                    count = newCount;
                    num = input[i];
                }
            }
            if (count == 0)
            {
                Console.WriteLine(input[0]);
                return;
            }
            for (int i = 0; i < count + 1; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
