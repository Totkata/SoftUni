using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumNum(num1,num2);
            int finalResult = Substract(sum, num3);

            Console.WriteLine(finalResult);
        }
        static int SumNum(int n1,int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        static int Substract(int summ, int n3)
        {
            int total = summ - n3;
            return total;
        }
    }
}
