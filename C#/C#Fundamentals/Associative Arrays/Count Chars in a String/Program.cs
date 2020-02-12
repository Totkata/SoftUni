using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> kvp = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (kvp.ContainsKey(letter))
                {
                    kvp[letter]++;
                }
                else
                {
                    kvp[letter] = 1;
                }
            }
            foreach (var item in kvp)
            {
                if (item.Key != ' ')
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
