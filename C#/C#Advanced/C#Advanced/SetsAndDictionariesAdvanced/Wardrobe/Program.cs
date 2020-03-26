using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                string key = input[0];
                List<string> value = input[1].Split(",").ToList();

                if (!wardrobe.ContainsKey(key))
                {
                    wardrobe.Add(key, value);
                }
                else
                {
                    foreach (var item in value)
                    {
                        wardrobe[key].Add(item);
                    }
                }
            }

            string[] secondInput = Console.ReadLine().Split(" ").ToArray();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                var clothes = new Dictionary<string, int>();

                foreach (var cloth in item.Value)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }

                foreach (var piece in clothes)
                {
                    if (piece.Key == secondInput[1] && item.Key == secondInput[0])
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece.Key} - {piece.Value}");
                    }
                }
            }
        }
    }
}
