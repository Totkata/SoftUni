using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> bombAndPowerx = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int bomb = bombAndPowerx[0];
            int bombPower = bombAndPowerx[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb)
                {
                    for (int k = 0; k < bombPower; k++)
                    {
                        if (i - 1 < 0)
                        {
                            break;
                        }
                        list.RemoveAt(i-1);
                        i--;
                    }
                    for (int j = i; j < i + bombPower; j++)
                    {
                        if (i + 1 > list.Count() - 1)
                        {
                            break;
                        }

                        list.RemoveAt(i + 1);
                    }
                    list.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
