using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }
                input = Console.ReadLine();
            }
            int stepsBackHome = int.Parse(Console.ReadLine());
            totalSteps += stepsBackHome;
            int neededSteps = 10000 - totalSteps;
            if (neededSteps > 0)
            {
                Console.WriteLine($"{neededSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
