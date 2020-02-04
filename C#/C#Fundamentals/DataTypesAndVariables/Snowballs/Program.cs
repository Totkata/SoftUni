using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            BigInteger bestSnowballValue = 0;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snow / time), quality);
                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestSnowballValue} ({bestQuality})");
        }
    }
}
