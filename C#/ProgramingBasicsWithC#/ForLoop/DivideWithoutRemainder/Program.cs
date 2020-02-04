using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 4 == 0)
                {
                    p3++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 2 == 0)
                {
                    p1++;
                }
            }
            double p1P = p1 / n * 100;
            double p2P = p2 / n * 100;
            double p3P = p3 / n * 100;

            Console.WriteLine($"{p1P:f2}%");
            Console.WriteLine($"{p2P:f2}%");
            Console.WriteLine($"{p3P:f2}%");
        }
    }
}
