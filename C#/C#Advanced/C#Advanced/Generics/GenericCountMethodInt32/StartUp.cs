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

            var boxes = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double obj = double.Parse(Console.ReadLine());
                boxes.Add(obj);
            }
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine(Count(boxes, value));
        }
        static int Count<T>(List<T> boxes, T value)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var item in boxes)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
