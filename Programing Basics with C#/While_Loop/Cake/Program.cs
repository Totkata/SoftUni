using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int cake = a * b;
            int peace = 1 * 1;

            int peacesCount = 0;

            string people = Console.ReadLine();

            while (people != "STOP")
            {
                int peopleCount = int.Parse(people);
                peacesCount += peopleCount * peace;
                if (peacesCount >= cake)
                {
                    int peacesNeed = peacesCount - cake;
                    Console.WriteLine($"No more cake left! You need {peacesNeed} pieces more.");
                    return;
                }
                people = Console.ReadLine();
            }
            int peacesLeft = cake - peacesCount;
            Console.WriteLine($"{peacesLeft} pieces are left.");
        }
    }
}
