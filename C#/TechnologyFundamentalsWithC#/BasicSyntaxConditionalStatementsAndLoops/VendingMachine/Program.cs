using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coinsSum = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins != 0.1 
                    && coins != 0.2 
                    && coins != 0.5 
                    && coins != 1 
                    && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    coinsSum += coins;
                }
                input = Console.ReadLine();
            }
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;

            input = Console.ReadLine();

            while (input != "End")
            {
                if (input != "Nuts"
                    && input != "Water"
                    && input != "Crisps"
                    && input != "Soda"
                    && input != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else if (input == "Nuts" && coinsSum >= nuts)
                {
                    coinsSum -= nuts;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (input == "Water" && coinsSum >= water)
                {
                    coinsSum -= water;
                    Console.WriteLine($"Purchased water");
                }
                else if (input == "Crisps" && coinsSum >= crisps)
                {
                    coinsSum -= crisps;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (input == "Soda" && coinsSum >= soda)
                {
                    coinsSum -= soda;
                    Console.WriteLine($"Purchased soda");
                }
                else if (input == "Coke" && coinsSum >= coke)
                {
                    coinsSum -= coke;
                    Console.WriteLine($"Purchased coke");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinsSum:f2}");
        }
    }
}
