using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyCost = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiqQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiqCost = whiskeyCost / 2;
            double wineCost = rakiqCost * 0.6;
            double beerCost = rakiqCost * 0.2;

            double totalWhiskey = whiskeyCost * whiskeyQuantity;
            double totalBeer = beerCost * beerQuantity;
            double totalWine = wineCost * wineQuantity;
            double totalRakiq = rakiqCost * rakiqQuantity;

            double totalPrice = totalWhiskey + totalBeer + totalWine + totalRakiq;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
