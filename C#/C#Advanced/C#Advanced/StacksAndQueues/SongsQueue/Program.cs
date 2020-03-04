using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if (!songs.Contains(item))
                {
                    songs.Enqueue(item);
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (songs.Count != 0)
            {
                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    List<string> list = new List<string>();
                    for (int i = 1; i < command.Length; i++)
                    {
                        list.Add(command[i]);
                    }
                    string song = string.Join(" ", list);
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
