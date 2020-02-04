using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBadGrades = int.Parse(Console.ReadLine());

            int badgrades = 0;
            double totalgrade = 0;
            int problemCount = 0;
            string lastProblem = string.Empty;

            string problem = Console.ReadLine();
            

            while (problem != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                problemCount++;
                totalgrade += grade;
                lastProblem = problem;

                if (grade <= 4)
                {
                    badgrades++;

                    if (badgrades == countBadGrades)
                    {
                        break;
                    }
                }

                problem = Console.ReadLine();
            }
            if (badgrades == countBadGrades)
            {
                Console.WriteLine($"You need a break, {badgrades} poor grades.");
            }
            else
            {
                double avarage = totalgrade / problemCount;
                Console.WriteLine($"Average score: {avarage:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
