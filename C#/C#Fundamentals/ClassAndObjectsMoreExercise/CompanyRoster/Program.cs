using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double salaryInput = double.Parse(input[1]);
                string department = input[2];

                Employee employee = new Employee(name, salaryInput, department);
                employees.Add(employee);
            }

            string bestDepartment = string.Empty;
            double bestAvarageSalary = 0.00;
            double salary = 0.00;
            double avarageSalary = 0.00;

            employees = employees.OrderBy(x => x.Department).ThenByDescending(x => x.Salary).ToList();

            List<string> departments = new List<string>();

            foreach (var person in employees)
            {
                string department = person.Department;

                if (departments.Count() == 0)
                {
                    departments.Add(department);
                    salary += person.Salary;
                    bestAvarageSalary = salary;
                    bestDepartment = department;
                    continue;
                }
                if (!departments.Contains(department))
                {
                    departments.Add(department);
                    salary = person.Salary;
                    if (salary > bestAvarageSalary)
                    {
                        bestAvarageSalary = salary;
                        bestDepartment = department;
                        continue;
                    }
                }
                else
                {
                    salary += person.Salary;
                    avarageSalary = salary / 2;
                    if (salary > bestAvarageSalary)
                    {
                        bestAvarageSalary = salary;
                        bestDepartment = department;
                        continue;
                    }
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var person in employees)
            {
                if (person.Department == bestDepartment)
                {
                    Console.WriteLine($"{person.Name} {person.Salary:f2}");
                }
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
