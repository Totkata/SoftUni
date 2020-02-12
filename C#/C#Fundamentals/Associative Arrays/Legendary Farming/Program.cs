using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {


            SortedDictionary<string, int> materials = new SortedDictionary<string, int>();

            SortedDictionary<string, int> keyMaterials = new SortedDictionary<string, int>();

            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();
                    bool breaker = false;
                    if (item == "motes" || item == "fragments" || item == "shards")
                    {
                        keyMaterials[item] += quantity;
                        Obtain(keyMaterials, breaker);
                    }
                    else
                    {
                        if (materials.ContainsKey(item))
                        {
                            materials[item] += quantity;
                        }
                        else
                        {
                            materials[item] = quantity;
                        }
                    }
                    if (breaker)
                    {
                        Print(keyMaterials, materials);
                        return;
                    }
                }
            }
        }
        static void Obtain(SortedDictionary<string,int> keyMaterials,bool breaker)
        {
            foreach (var kvp in keyMaterials)
            {
                if (kvp.Key == "motes".ToLower() && kvp.Value >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    keyMaterials["motes"] -= 250;
                    breaker = true;
                    break;
                }
                else if (kvp.Key == "fragments" && kvp.Value >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    keyMaterials["fragments"] -= 250;
                    breaker = true;
                    break;
                }
                else if (kvp.Key == "shards" && kvp.Value >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    keyMaterials["shards"] -= 250;
                    breaker = true;
                    break;
                }
            }
        }
        static void Print(SortedDictionary<string,int> keyMaterials, SortedDictionary<string, int> materials)
        {
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in materials.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

