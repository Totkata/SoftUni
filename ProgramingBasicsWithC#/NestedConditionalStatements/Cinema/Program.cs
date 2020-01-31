using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int cow = int.Parse(Console.ReadLine());

            if (projectionType == "Premiere")
            {
                double income = row * cow * 12.00;
                Console.WriteLine($"{income:f2} leva");
            }
            else if (projectionType == "Normal")
            {
                double income = row * cow * 7.50;
                Console.WriteLine($"{income:f2} leva");
            }
            else if (projectionType == "Discount")
            {
                double income = row * cow * 5.00;
                Console.WriteLine($"{income:f2} leva");
            }
        }
    }
}
