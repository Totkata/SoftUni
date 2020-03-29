using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (End(command))
            {
                if (command == "add")
                {
                    arr = Add(arr);
                }
                else if (command == "multiply")
                {
                    arr = Multiply(arr);
                }
                else if (command == "subtract")
                {
                    arr = Subtract(arr);
                }
                else if (command == "print")
                {
                    Print(arr);
                }
                command = Console.ReadLine();
            }
        }
        public static int[] Add(int[] arr)
        {
            List<int> newArr = new List<int>();
            foreach (var number in arr)
            {
                newArr.Add(number + 1);
            }
            arr = newArr.ToArray();
            return arr;
        }
        public static int[] Multiply(int[] arr)
        {
            List<int> newArr = new List<int>();
            foreach (var number in arr)
            {
                newArr.Add(number * 2);
            }
            arr = newArr.ToArray();
            return arr;
        }
        public static int[] Subtract(int[] arr)
        {
            List<int> newArr = new List<int>();
            foreach (var number in arr)
            {
                newArr.Add(number - 1);
            }
            arr = newArr.ToArray();
            return arr;
        }
        public static string Print(int[] arr)
        {
            string output = string.Join(" ", arr);
            Console.WriteLine(output);
            return output;
        }
        public static bool End(string command)
        {
            if (command == "end")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    }
}
