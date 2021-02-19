namespace ConsoleApp1
{
    using BookLibrary;
    using System;
    using System.Collections.Immutable;

    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            Book book = new Book("A", 19922);
            book.AddAuhtor("J. K. Rowling");
            library.AddBook(book);

            book = new Book("B", 1999);
            book.AddAuhtor("J. Rowling");
            library.AddBook(book);

            book = new Book("Z", 2001);
            book.AddAuhtor("Rowling");
            library.AddBook(book);


            foreach (var bookInfo in library)
            {
                Console.WriteLine(bookInfo.ToString());
            }
        }
    }
}