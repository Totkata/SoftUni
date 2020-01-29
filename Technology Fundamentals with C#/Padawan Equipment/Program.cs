using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersCount = Math.Ceiling(studentCount * 1.1);
            double beltsDiscount = Math.Floor(studentCount / 6.0);
            double beltCount = studentCount - beltsDiscount;

            double lightsabersSum = lightsabersPrice * lightsabersCount;
            double beltSum = beltsPrice * beltCount;
            double robeSum = robePrice * studentCount;
            double totalSum = lightsabersSum + beltSum + robeSum;
            double moneyNeed = totalSum - buget;

            if (buget >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyNeed:f2}lv more.");
            }
        }
    }
}
