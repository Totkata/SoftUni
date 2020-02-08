using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ReadThreeNumbers();
            int smallestNum = FindBigestNumber(arr);
            Console.WriteLine(smallestNum);
        }
        static int[] ReadThreeNumbers()
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static int FindBigestNumber(int[] arr)
        {
            int smallestNum = int.MaxValue;
            foreach (var num in arr)
            {
                if (num < smallestNum)
                {
                    smallestNum = num;
                }
            }
            return smallestNum;
        }
    }
}
