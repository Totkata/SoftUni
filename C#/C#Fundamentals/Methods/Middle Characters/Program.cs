using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string middleCharacter = MiddleCharacter(input);

            Console.WriteLine(middleCharacter);
        }
        static string MiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                int index = input.Length / 2;
                string output = input[index - 1].ToString() + input[index].ToString();
                return output;
            }
            else
            {
                string index = Math.Floor(input.Length / 2.0).ToString();
                int parsedIndex = int.Parse(index);
                string output = input[parsedIndex].ToString();
                return output;
            }
        }
    }
}
