using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int currentPokePower = pokePower;

            int count = 0;
            while (currentPokePower >= distance)
            {
                currentPokePower -= distance;
                count++;
                if (currentPokePower == pokePower / 2 && exhaustion != 0 && currentPokePower != 0)
                {
                    currentPokePower /= exhaustion;
                }
            }

            Console.WriteLine(currentPokePower);
            Console.WriteLine(count);
        }
    }
}
