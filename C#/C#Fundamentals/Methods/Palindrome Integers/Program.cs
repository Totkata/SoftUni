using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "END")
            {
                Palindrome(input);
                input = Console.ReadLine();
            }
        }
        static void Palindrome(string num)
        {
            int num1 = int.Parse(num); 
            string number = string.Empty;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                number += num[i];
            }
            int num2 = int.Parse(number);
            if (num1 == num2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
