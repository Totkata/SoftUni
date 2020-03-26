using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] splitedInput = input.Split(" ").ToArray();

                string name = splitedInput[0];
                string command = splitedInput[1];
                string follow = splitedInput[2];

                if (command == "joined")
                {
                    if (!vlogers.ContainsKey(name))
                    {
                        vlogers.Add(name, new Dictionary<string, HashSet<string>>());
                        vlogers[name].Add("followers", new HashSet<string>());
                        vlogers[name].Add("followings", new HashSet<string>());
                    }
                }
                else if (command == "followed"
                    && name != follow
                    && vlogers.ContainsKey(name)
                    && vlogers.ContainsKey(follow))
                     {
                         if (!vlogers[name]["followings"].Contains(follow))
                         {
                             vlogers[name]["followings"].Add(follow);
                             vlogers[follow]["followers"].Add(name);
                         }
                     }
                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");

            int number = 1;

            foreach (var vlogger in vlogers.OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["followings"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["followings"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}
