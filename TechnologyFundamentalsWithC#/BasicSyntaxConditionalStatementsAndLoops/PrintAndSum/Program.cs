using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                sum += i;
                if (i == num2)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.Write($"{i} ");
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
