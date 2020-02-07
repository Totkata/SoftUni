using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> train = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int vagon = int.Parse(Console.ReadLine());
                train.Add(vagon);
            }
            foreach (var item in train)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(train.Sum());
        }
    }
}
