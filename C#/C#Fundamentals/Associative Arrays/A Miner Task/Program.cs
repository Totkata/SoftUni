using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> storage = new Dictionary<string, int>();
            
            while (input != "stop")
            {
                string metal = input;
                int quantity = int.Parse(Console.ReadLine());

                if (storage.ContainsKey(metal))
                {
                    storage[metal] += quantity;
                }
                else
                {
                    storage[metal] = quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var item in storage)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
