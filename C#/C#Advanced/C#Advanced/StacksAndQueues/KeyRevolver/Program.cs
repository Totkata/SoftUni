using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] locksArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bullets = new Stack<int>();

            foreach (var item in bulletsArr)
            {
                bullets.Push(item);
            }

            Queue<int> locks = new Queue<int>();

            foreach (var item in locksArr)
            {
                locks.Enqueue(item);
            }

            int value = int.Parse(Console.ReadLine());

            int bulletCount = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {
                int bulletsLeftInBarroll = 0;

                for (int i = 0; i < gunBarrelSize; i++)
                {
                    if (bullets.Count == 0 || locks.Count == 0)
                    {
                        break;
                    }

                    int bullet = bullets.Peek();

                    int locker = locks.Peek();

                    bullets.Pop();

                    bulletsLeftInBarroll++;

                    if (bullet <= locker)
                    {
                        bulletCount++;
                        locks.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        bulletCount++;
                        Console.WriteLine("Ping!");
                    }
                }

                if (bulletCount % gunBarrelSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Count == 0)
            {
                int bulletsLeft = bullets.Count();
                int moneyEarned = value - (bulletCount * bulletPrice);
                Console.WriteLine($"{ bulletsLeft} bullets left. Earned ${ moneyEarned}");
            }
            else
            {
                int locksLeft = locks.Count();
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
        }
    }
}
