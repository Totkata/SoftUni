using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            double usdToBgn = input * 1.79549;

            Console.WriteLine($"{usdToBgn:f2}");
        }
    }
}
