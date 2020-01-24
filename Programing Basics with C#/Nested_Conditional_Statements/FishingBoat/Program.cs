using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishmanCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            if (season == "Spring")
            {
                totalPrice+= 3000;
            }
            else if (season == "Summer")
            {
                totalPrice += 4200;
            }
            else if (season == "Autumn")
            {
                totalPrice += 4200;
            }
            else if (season == "Winter")
            {
                totalPrice += 2600;
            }

            if (fishmanCount <= 6)
            {
                totalPrice *= 0.9;
            }
            else if (fishmanCount >= 7 && fishmanCount <= 11)
            {
                totalPrice *= 0.85;
            }
            else if (fishmanCount >= 12)
            {
                totalPrice *= 0.75;
            }

            if (fishmanCount % 2 == 0 && season != "Autumn")
            {
                totalPrice *= 0.95;
            }

            if (buget >= totalPrice)
            {
                double moneyLeft = buget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = totalPrice - buget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
