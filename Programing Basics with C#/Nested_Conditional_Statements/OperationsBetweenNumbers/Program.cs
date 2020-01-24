using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           double n1 = double.Parse(Console.ReadLine());
           double n2 = double.Parse(Console.ReadLine());
            string operrator = Console.ReadLine();

            if (operrator == "+")
            {
                double result = n1 + n2;
                string evenOrOdd = string.Empty;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operrator} {n2} = {result} – {evenOrOdd}");
            }
            else if (operrator == "-")
            {
                double result = n1 - n2;
                string evenOrOdd = string.Empty;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operrator} {n2} = {result} – {evenOrOdd}");
            }
            else if (operrator == "*")
            {
                double result = n1 * n2;
                string evenOrOdd = string.Empty;

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operrator} {n2} = {result} – {evenOrOdd}");
            }
            else if (operrator == "/" && n2 != 0)
            {
                double result = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (operrator == "%")
            {
                double result = n1 % n2;
                Console.WriteLine($"{n1} / {n2} = {result}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
