using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 16; i < number; i++)
            {
                if (IsDivisibleByEight(i) && ContainAtLeastOneOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool ContainAtLeastOneOdd(int num1)
        {
            string numToString = num1.ToString();
            int lenght = numToString.Length;

            char[] stringToChar = numToString.ToCharArray();

            int[] number = new int[lenght];

            int counter = 0;

            for (int i = 0; i < lenght - 1; i++)
            {
                string num = stringToChar[i].ToString();
                number[i] = int.Parse(num);
            }
            for (int i = 0; i < lenght; i++)
            {
                if (number[i] % 2 != 0)
                {
                    counter += 1;
                }
            }
            if (counter >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsDivisibleByEight(int num)
        {
            string input = num.ToString();
            int sum = 0;
            foreach (var item in input)
            {
                sum += int.Parse(item.ToString());
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
