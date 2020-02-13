using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> firstHalf = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                {
                    firstHalf.Push(input[i]);
                }
                else if (firstHalf.Count != 0)
                {
                    char reversedItem = ' ';
                    if (input[i].ToString() == "}")
                    {
                        reversedItem = '{';
                    }
                    else if (input[i].ToString() == ")")
                    {
                        reversedItem = '(';
                    }
                    else if (input[i].ToString() == "]")
                    {
                        reversedItem = '[';
                    }
                    if (firstHalf.Peek() == reversedItem)
                    {
                        firstHalf.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
