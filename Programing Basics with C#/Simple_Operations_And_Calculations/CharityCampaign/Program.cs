using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int bakerCount = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int gofretsCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            int cakePrice = 45;
            double gofretsPrice = 5.80;
            double pancakesPrice = 3.20;

            double cakeTotal = cakePrice * cakeCount;
            double gofretsTotal = gofretsPrice * gofretsCount;
            double pancakesTotal = pancakesPrice * pancakesCount;

            double totalForADay = (cakeTotal + gofretsTotal + pancakesTotal) * bakerCount;

            double totalSum = totalForADay * dayCount;

            double expenses = totalSum / 8;

            double profit = totalSum - expenses;

            Console.WriteLine($"{profit:f2}");
        }
    }
}
