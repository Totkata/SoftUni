using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            double degreeConvert = input * 180 / Math.PI;

            double roundedResult = Math.Round(degreeConvert);
            Console.WriteLine(roundedResult);
        }
    }
}
