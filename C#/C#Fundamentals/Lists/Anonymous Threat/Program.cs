using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ")
                .ToList();

        https://pastebin.com/ssA78LUF

            string comand = Console.ReadLine();

            while (comand != "3:1")
            {
                List<string> splitedComand = comand.Split(" ").ToList();

                if (splitedComand[0] == "merge")
                {
                    int startIndex = int.Parse(splitedComand[1]);
                    int endIndex = int.Parse(splitedComand[2]);

                    int difference = endIndex - startIndex;

                    Merge(startIndex, endIndex, difference, input);
                }
                else if (splitedComand[0] == "divide")
                {
                    int index = int.Parse(splitedComand[1]);
                    int partitions = int.Parse(splitedComand[2]);

                    string dividedPart = input[index];
                    double newPartsLenght = 0;

                    List<string> newPartsList = new List<string>();

                    if (dividedPart.Length % partitions == 0)
                    {
                        DivideEven(newPartsLenght, dividedPart, partitions, newPartsList);
                    }
                    else
                    {
                        DivideOdd(newPartsLenght, dividedPart, partitions, newPartsList);
                    }

                    input.RemoveAt(index);
                    newPartsList.Reverse();
                    foreach (var item in newPartsList)
                    {
                        input.Insert(index, item);
                    }
                }
                comand = Console.ReadLine();
            }
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }
        }
        static void DivideOdd(double newPartsLenght, string dividedPart, int partitions, List<string> newPartsList)
        {
            newPartsLenght = (dividedPart.Length / partitions);
            int currentIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                if (i != partitions - 1)
                {
                    double lenght = newPartsLenght;
                    string part = string.Empty;
                    for (int j = currentIndex; j < lenght + currentIndex; j++)
                    {
                        part += dividedPart[j];
                        currentIndex++;
                        lenght--;
                    }
                    newPartsList.Add(part);
                }
                else
                {
                    double lenght = newPartsLenght + 1;
                    string part = string.Empty;
                    for (int j = currentIndex; j < lenght + currentIndex; j++)
                    {
                        part += dividedPart[j];
                        currentIndex++;
                        lenght--;
                    }
                    newPartsList.Add(part);
                }
            }
        }
        static void DivideEven(double newPartsLenght, string dividedPart, int partitions, List<string> newPartsList)
        {
            newPartsLenght = dividedPart.Length / partitions;
            int currentIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                double lenght = newPartsLenght;
                string part = string.Empty;
                for (int j = currentIndex; j < lenght + currentIndex; j++)
                {
                    part += dividedPart[j];
                    currentIndex++;
                    lenght--;
                }
                newPartsList.Add(part);
            }
        }
        static void Merge(int startIndex, int endIndex, int difference, List<string> input)
        {
            int currentIndex = startIndex + difference;

            for (int i = startIndex; i < currentIndex; currentIndex--)
            {
                if (i + 1 < endIndex && input.Count() > startIndex + 1)
                {
                    input[startIndex] += input[i + 1];
                    input.RemoveAt(i + 1);
                }
            }
        }
    }
}

