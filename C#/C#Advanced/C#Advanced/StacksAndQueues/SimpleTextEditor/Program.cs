using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            int count = int.Parse(Console.ReadLine());

            Stack<string> undoText = new Stack<string>();
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "1")
                {
                    undoText.Push(text);
                    text += command[1].ToString();
                }
                else if (command[0] == "2")
                {
                    undoText.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(command[1]));
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4")
                {
                    text = undoText.Pop();
                }
            }
            Console.WriteLine(text);
        }
    }
}

