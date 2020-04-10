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

            var boxes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string obj = Console.ReadLine();
                boxes.Add(obj);
            }
            string comparingElement = Console.ReadLine();
            Console.WriteLine(Count(boxes, comparingElement));
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
