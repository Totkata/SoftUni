using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|").ToList();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                List<string> arraysWithoutSpaces = arrays[i].Split(" ").ToList();
                for (int j = 0; j < arraysWithoutSpaces.Count; j++)
                {
                    if (arraysWithoutSpaces[j] != "")
                    {
                        Console.Write(arraysWithoutSpaces[j] + " ");
                    }

                }
            }
        }
    }
}
