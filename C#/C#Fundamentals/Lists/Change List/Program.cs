using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] convertedInput = input.Split(" ");

                string command = convertedInput[0];
                if (command == "Delete")
                {
                    int element = int.Parse(convertedInput[1]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        int item = list[i];
                        if (item == element)
                        {
                            list.Remove(item);
                        }
                    }
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(convertedInput[1]);
                    int position = int.Parse(convertedInput[2]);

                    list.Insert(position, element);
                }
                input = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
