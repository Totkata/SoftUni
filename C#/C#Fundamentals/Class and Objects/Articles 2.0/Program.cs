using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];
                var article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles.Sort((x, y) => x.Title.CompareTo(y.Title));
            }
            else if (criteria == "content")
            {
                articles.Sort((x, y) => x.Content.CompareTo(y.Content));
            }
            else if (criteria == "author")
            {
                articles.Sort((x, y) => x.Author.CompareTo(y.Author));
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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

        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}
