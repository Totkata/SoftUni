using System;
using System.Linq;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int copyInput = input;
            int inputSum = 0;

            while (copyInput != 0)
            {
                inputSum += copyInput % 10;
                copyInput /= 10;
            }
            Console.WriteLine(inputSum);
        }
    }
}
