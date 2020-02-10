using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] convertedInput = input.Split(" ");
                if (convertedInput.Count() > 1)
                {
                    int passengers = int.Parse(convertedInput[1]);

                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(convertedInput[0]);
                    foreach (var currentPassangers in train)
                    {
                        if (currentPassangers + passengers <= wagonCapacity)
                        {
                            int sum = currentPassangers + passengers;
                            int index = train.IndexOf(currentPassangers);
                            train.Remove(currentPassangers);
                            train.Insert(index, sum);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var num in train)
            {
                Console.Write(num + " ");
            }
        }
    }
}
