using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (startingPoints < 100)
            {
                bonusPoints += 5;
            }
            else if (startingPoints > 100 && startingPoints < 1000)
            {
                bonusPoints += startingPoints * 0.2;
            }
            else if (startingPoints > 1000)
            {
                bonusPoints += startingPoints * 0.1;
            }

            if (startingPoints % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (startingPoints % 5 == 0 && startingPoints % 2 != 0)
            {
                bonusPoints += 2;
            }

            double totalPoints = bonusPoints + startingPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}
