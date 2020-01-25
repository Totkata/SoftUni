using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();

            int bookCount = int.Parse(Console.ReadLine());

            string thisBook = string.Empty;
            int checkedBooks = 0;
            int booksLeft = bookCount;
            while (bookName != thisBook && booksLeft > 0)
            {
                thisBook = Console.ReadLine();
                if (thisBook == bookName)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    return;
                }
                checkedBooks++;
                booksLeft--;
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCount} books.");
        }
    }
}
