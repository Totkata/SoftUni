using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Func<int[], int> predicate = SmallestNumber;

            Console.WriteLine(predicate(input));
        }

        static int SmallestNumber(int[] arr)
        {
            int minNum = int.MaxValue;
            foreach (var item in arr)
            {
                if (item < minNum)
                {
                    minNum = item;
                }
            }
            return minNum;
        }
    }
}
