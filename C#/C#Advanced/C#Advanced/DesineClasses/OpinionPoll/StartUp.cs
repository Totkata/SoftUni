using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var poll = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (age > 30)
                {
                    poll.Add(new Person(name, age));
                }
            }
            foreach (var person in poll.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
