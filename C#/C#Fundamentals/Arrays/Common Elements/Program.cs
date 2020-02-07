using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> first = Console.ReadLine().Split().ToList();
            List<string> second = Console.ReadLine().Split().ToList();

            foreach (var item in second)
            {
                foreach (var item2 in first)
                {
                    if (item == item2)
                    {
                        Console.Write(item+ " ");
                    }
                }
            }
        }
    }
}
