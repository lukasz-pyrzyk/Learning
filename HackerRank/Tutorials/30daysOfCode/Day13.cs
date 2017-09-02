using System;

namespace _30daysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-abstract-classes
    /// </summary>
    public class Day13
    {
        public abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        public class MyBook : Book
        {
            public int Price { get; }

            public MyBook(string title, string author, int price) : base(title, author)
            {
                Price = price;
            }

            public override void display()
            {
                string str = $"Title: {author}\r\nAuthor: {author}\r\nPrice: {Price}";
                Console.WriteLine(str);
            }
        }
    }
}
