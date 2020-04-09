using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int obj = int.Parse(Console.ReadLine());
                var box = new Box<int>(obj);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
