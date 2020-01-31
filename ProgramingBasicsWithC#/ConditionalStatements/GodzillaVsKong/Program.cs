using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statistClothPrice = double.Parse(Console.ReadLine());

            double discount = 0;
            double decors = buget * 0.1;

            if (statists > 150)
            {
                discount = (statistClothPrice * statists) * 0.1;
            }

            double totalClothPrice = (statistClothPrice * statists) - discount;
            double total = totalClothPrice + decors;

            if (total > buget)
            {
                double moneyNeeded = Math.Abs(buget - total);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else
            {
                double moneyLeft = buget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
