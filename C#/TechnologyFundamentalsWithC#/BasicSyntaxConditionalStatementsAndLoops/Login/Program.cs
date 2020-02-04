using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();
            char[] password = new char[input.Length];

           
            int tryCount = 0;
            while (true)
            {
                if (username.Length != input.Length)
                {
                    tryCount++;
                    Console.WriteLine("Incorrect password. Try again.");
                    input = Console.ReadLine();
                }
                else
                {
                    int n = 0;
                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        for (int j = n; j < input.Length; j++)
                        {
                            password[j] = input[i];
                            n++;
                            break;
                        }
                    }
                    if (username == string.Join("", password))
                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }
                    tryCount++;
                    if (tryCount == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    input = Console.ReadLine();
                }
                if (tryCount == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
        }
    }
}
