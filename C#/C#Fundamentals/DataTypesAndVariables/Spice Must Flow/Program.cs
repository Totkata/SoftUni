using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCount = 0;
            int storage = 0;

            while (yield >= 100)
            {
                storage += yield;
                dayCount++;
                if (storage >= 26)
                {
                    storage -= 26;
                }
                yield -= 10;
            }
            if (storage >= 26)
            {
                storage -= 26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(storage);
        }
    }
}
