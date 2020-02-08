using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int count = VowelsCount(word);
            Console.WriteLine(count);
        }
        static int VowelsCount (string word)
        {
            int count = 0;
            foreach (var item in word)
            {
                if (item == 'a' ||
                    item == 'e' ||
                    item == 'i' ||
                    item == 'o' ||
                    item == 'u' ||
                    item == 'y')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
