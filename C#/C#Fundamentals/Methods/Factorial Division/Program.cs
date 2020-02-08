using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialNum = int.Parse(Console.ReadLine());
            int divisionNum = int.Parse(Console.ReadLine());

            long firstFactorial = FindFactorialNumber(factorialNum);
            long secondeFactorial = FindFactorialNumber(divisionNum);

            decimal total = (decimal)firstFactorial / secondeFactorial;
            Console.WriteLine($"{total:F2}");
        }

        private static long FindFactorialNumber(long number)
        {
            long factorialSum = 1;
            for (int i = 2; i <= number; i++)
            {
                factorialSum *= i;
            }
            return factorialSum;
        }
    }
}
