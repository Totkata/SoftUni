using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatur = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (temperatur >= 10 && temperatur <= 18)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperatur > 18 && temperatur <= 24)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperatur >= 25)
            {
                if (partOfTheDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfTheDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {temperatur} degrees, get your {outfit} and {shoes}.");
        }
    }
}
