using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                var student = new Student(name,lastName,grade);

                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public Student(string firstName,string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            string result = $"{FirstName} {LastName}: {Grade:f2}";
            return result;
        }
    }
}
