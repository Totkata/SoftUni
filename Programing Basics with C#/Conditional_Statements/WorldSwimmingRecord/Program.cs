using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double metersToSwim = double.Parse(Console.ReadLine());
            double secondsForMeter = double.Parse(Console.ReadLine());

            double timeIvanGetsSwoled = Math.Floor(metersToSwim / 15) * 12.5;

            double ivansTime = metersToSwim * secondsForMeter + timeIvanGetsSwoled;

            if (recordSeconds > ivansTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                double secondsIvanNeed = ivansTime - recordSeconds;
                Console.WriteLine($"No, he failed! He was {secondsIvanNeed:f2} seconds slower.");
            }
        }
    }
}
