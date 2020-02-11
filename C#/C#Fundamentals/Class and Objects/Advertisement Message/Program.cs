using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product." , "Such a great product." ,
                "I always use that product." , "Best product of its category." ,
                "Exceptional product.","I can’t live without this product."};
            string[] events = {"Now I feel good.", "I have succeeded with this product.","Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome." , "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] names = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] towns = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random number = new Random(input);
            for (int i = 0; i < input; i++)
            {
                int indexPhrase = number.Next(phrases.Length);
                int eventsIndex = number.Next(events.Length);
                int indexnames = number.Next(names.Length);
                int indextowns = number.Next(towns.Length);
                Console.WriteLine($"{phrases[indexPhrase]} {events[eventsIndex]} {names[indexnames]} – {towns[indextowns]}.");
            }
        }
    }
}
