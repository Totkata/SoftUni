using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minimumIncome = double.Parse(Console.ReadLine());

            double socialScolarship = Math.Floor(minimumIncome * 0.35);
            double scolarship = Math.Floor(grades * 25);


            if (grades >= 5.5)
            {
                if (scolarship >= socialScolarship || income > minimumIncome)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scolarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scolarship} BGN");
                }
            }
            else if (income < minimumIncome && grades > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
