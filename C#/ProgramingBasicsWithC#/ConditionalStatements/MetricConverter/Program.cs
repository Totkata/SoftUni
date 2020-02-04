using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToConvert = double.Parse(Console.ReadLine());

            string type = Console.ReadLine();
            string typeToConvert = Console.ReadLine();

            double converted = 0;
            if (type == "m")
            {
                if (typeToConvert == "mm")
                {
                    converted = numberToConvert * 1000;
                    Console.WriteLine($"{converted:f3}");
                }
                else if (typeToConvert == "cm")
                {
                    converted = numberToConvert * 100;
                    Console.WriteLine($"{converted:f3}");
                }
            }
            else if (type == "mm")
            {
                if (typeToConvert == "m")
                {
                    converted = numberToConvert / 1000;
                    Console.WriteLine($"{converted:f3}");
                }
                else if (typeToConvert == "cm")
                {
                    converted = numberToConvert / 10;
                    Console.WriteLine($"{converted:f3}");
                }
            }
            else if (type == "cm")
            {
                if (typeToConvert == "mm")
                {
                    converted = numberToConvert * 10;
                    Console.WriteLine($"{converted:f3}");
                }
                else if (typeToConvert == "m")
                {
                    converted = numberToConvert / 100;
                    Console.WriteLine($"{converted:f3}");
                }
            }
        }
    }
}
