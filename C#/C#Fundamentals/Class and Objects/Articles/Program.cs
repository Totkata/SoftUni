using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author= input[2];
            var article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();

                string text = command[1];
                if (command[0] == "Edit")
                {
                    article.Edit(text);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAutor(text);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(text);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAutor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result; 
        }
    }
}
