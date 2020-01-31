using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bigestKeg = string.Empty;
            double bigetsValue = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int high = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * high;

                if (volume > bigetsValue)
                {
                    bigetsValue = volume;
                    bigestKeg = model;
                }
            }
            Console.WriteLine(bigestKeg);
        }
    }
}

