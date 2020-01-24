using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.50;

            double totalPrice = 0;

            if (flowerType == "Roses")
            {
                totalPrice = flowerCount * rosePrice;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                totalPrice = flowerCount * dahliasPrice;
                if (flowerCount > 90)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                totalPrice = flowerCount * tulipsPrice;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                totalPrice = flowerCount * narcissusPrice;
                if (flowerCount < 120)
                {
                    totalPrice *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                totalPrice = flowerCount * gladiolusPrice;
                if (flowerCount < 80)
                {
                    totalPrice *= 1.2;
                }
            }
            
            if (totalPrice <= buget)
            {
                double sumLeft = buget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {sumLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - buget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
