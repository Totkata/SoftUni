using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int currentCapacity = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int check = currentCapacity + input;
                if (check <= tankCapacity)
                {
                    currentCapacity += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentCapacity);
        }
    }
}
