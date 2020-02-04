using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = new double[4];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            double coordinatOne = Math.Abs(input[0] - input[2]);
            double coordinatTwo = Math.Abs(input[1] - input[3]);

            double area = coordinatOne * coordinatTwo;
            double perimeter = 2 * (coordinatOne + coordinatTwo);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
