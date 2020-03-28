using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var validation = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] splitedInput = input.Split(":").ToArray();

                string contest = splitedInput[0];
                string password = splitedInput[1];

                validation.Add(contest, password);

                input = Console.ReadLine();
            }

            var users = new Dictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] splitedInput = input.Split("=>").ToArray();

                string contest = splitedInput[0];
                string password = splitedInput[1];
                string username = splitedInput[2];
                int points = int.Parse(splitedInput[3]);

                if (validation.ContainsKey(contest) && validation[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new Dictionary<string, int>());
                        users[username].Add(contest, points);
                    }
                    else if (!users[username].ContainsKey(contest))
                    {
                        users[username].Add(contest, points);
                    }
                    else if (users[username][contest] < points)
                    {
                        users[username][contest] = points;
                    }
                }

                input = Console.ReadLine();
            }

            int maxScore = int.MinValue;
            string bestUser = string.Empty;

            foreach (var item in users)
            {
                if (users[item.Key].Values.Sum() > maxScore)
                {
                    maxScore = users[item.Key].Values.Sum();
                    bestUser = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {maxScore} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var cource in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {cource.Key} -> {cource.Value}");
                }
            }
        }
    }
}
