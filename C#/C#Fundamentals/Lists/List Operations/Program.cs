using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
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

            while (input != "End")
            {
                string[] command = input.Split(" ");

                if (command[0] == "Add")
                {
                    int num = int.Parse(command[1]);
                    list.Add(num);
                }
                else if (command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (list.Count() > index && index > -1)
                    {
                        list.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (list.Count() > index && index > -1)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int item = list[0];
                        list.RemoveAt(0);
                        list.Add(item);
                    }
                }
                else if (command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int index = list.Count();
                        int item = list[index - 1];
                        list.RemoveAt(index - 1);
                        list.Insert(0,item);
                    }
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
