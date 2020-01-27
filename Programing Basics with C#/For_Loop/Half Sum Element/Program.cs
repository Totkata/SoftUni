using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bigest = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > bigest)
                {
                    bigest = num;
                }
                sum += num;
            }
            if (sum - bigest == bigest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - bigest}");
            }
            else
            {
                int diff = Math.Abs(bigest - (sum - bigest));
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
