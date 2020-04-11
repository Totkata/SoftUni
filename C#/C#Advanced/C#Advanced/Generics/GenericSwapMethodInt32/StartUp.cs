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

            var boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int obj = int.Parse(Console.ReadLine());

                var box = new Box<int>(obj);
                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int x = indexes[0];
            int y = indexes[1];

            Swap(boxes,x,y);

            foreach (var item in boxes)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap<T>(List<Box<T>> boxes, int x, int y)
        {
            Box<T> temp = boxes[x];
            boxes[x] = boxes[y];
            boxes[y] = temp;
        }
    }
}
