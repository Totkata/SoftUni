using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currMoney = double.Parse(Console.ReadLine());
            int spendCount = 0;
            int totalDays = 0;
            while (moneyNeeded > currMoney)
            {
                string doing = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalDays++;
                if (doing == "spend")
                {
                    spendCount++;
                    if (currMoney - money < 0)
                    {
                        currMoney = 0;
                    }
                    else
                    {
                        currMoney -= money; 
                    }
                }
                else
                {
                    currMoney += money;
                    spendCount = 0;
                }
                if (spendCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(totalDays);
                    return;
                }
            }
            Console.WriteLine($"You saved the money for {totalDays} days.");
        }
    }
}