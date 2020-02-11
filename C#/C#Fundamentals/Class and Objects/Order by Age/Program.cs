using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();
            
            while (input != "End")
            {
                string[] splitedInput = input.Split(" ");

                string name = splitedInput[0];
                int id = int.Parse(splitedInput[1]);
                int age = int.Parse(splitedInput[2]);

                Person person = new Person(name,id,age);
                persons.Add(person);
                input = Console.ReadLine();
            }
            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
    class Person
    {
        public Person(string name,int id,int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            string result = $"{Name} with ID: {ID} is {Age} years old.";
            return result;
        }
    }
}
