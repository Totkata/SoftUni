using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLights = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int currendGreen = greenLights;
                    while (currendGreen > 0 && cars.Count > 0)
                    {
                        string car = cars.Peek();
                        if (car.Length <= currendGreen)
                        {
                            cars.Dequeue();
                            count++;
                            currendGreen -= car.Length;
                        }
                        else if (car.Length <= currendGreen + freeWindowDuration)
                        {
                            cars.Dequeue();
                            count++;
                            break;
                        }
                        else
                        {
                            int timeLeft = currendGreen + freeWindowDuration;

                            char[] arr = car.ToCharArray();

                            char crashPoint = arr[timeLeft];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {crashPoint}.");
                            return;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
