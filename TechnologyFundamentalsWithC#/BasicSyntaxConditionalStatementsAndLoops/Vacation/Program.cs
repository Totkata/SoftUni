using System;

namespace Vacation
{
    class Program
    {
        // Гърми 83/100??????


        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = price * countOfPeople;
            double discounted = 0;

            if(groupType == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                discounted = totalPrice * 0.05;

            }
            else if (groupType == "Business" && countOfPeople >= 100)
            {
                discounted = 10 * price;

            }
            else if (groupType == "Students" && countOfPeople >= 30)
            {
                discounted = totalPrice * 0.15;

            }

            Console.WriteLine($"Total price: {(totalPrice - discounted):f2}");
        }
    }
}
