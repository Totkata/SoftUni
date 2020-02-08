using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if (start < end)
            {
                for (char i = start; i < end; i++)
                {
                    if (i != start)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (char i = end; i < start; i++)
                {
                    if (i != end)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
