using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;

            double moneySpent = buget;

            if (buget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneySpent *= 0.3;
                }
                else if (season == "winter")
                {
                    moneySpent *= 0.7;
                }
            }
            else if (buget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneySpent *= 0.4;
                }
                else if (season == "winter")
                {
                    moneySpent *= 0.8;
                }
            }
            else if (buget > 1000)
            {
                destination = "Europe";
                moneySpent *= 0.9;
            }
            string place = string.Empty;

            if (season == "summer" && destination == "Europe")
            {
                place = "Hotel";
            }
            else if (season == "winter" )
            {
                place = "Hotel";
            }
            else
            {
                place = "Camp";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {moneySpent:f2}");
        }
    }
}
