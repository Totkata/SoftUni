using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfTheOrder = int.Parse(Console.ReadLine());

            double lenghOfTheTable = double.Parse(Console.ReadLine());
            double widthOfTheTable = double.Parse(Console.ReadLine());

            double quadsSide = lenghOfTheTable / 2;

            double tableClothPriceUSD = 7;
            double quadsClothPriceUSD = 9;

            double USDtoBGN = 1.85;

            double tableArea = (lenghOfTheTable + 2 * 0.30) * (widthOfTheTable + 2 * 0.30);
            double quadsArea = quadsSide * quadsSide;

            double priceForTableclothsUSD = (tableArea * quantityOfTheOrder) * tableClothPriceUSD;
            double priceForQuadsUSD = (quadsArea * quantityOfTheOrder) * quadsClothPriceUSD;

            double totalPrice = priceForTableclothsUSD + priceForQuadsUSD;
            double totalPriceBGN = totalPrice * USDtoBGN;

            Console.WriteLine($"{totalPrice:f2} USD");
            Console.WriteLine($"{totalPriceBGN:f2} BGN");
        }
    }
}
