using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person newMember = new Person(name,age);
                family.AddFamilyMember(newMember);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
