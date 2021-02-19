namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year)
        {
            this.title = title;
            this.year = year;
            this.authors = new List<string>();
        }
        public int Year { get { return this.year; } }
        public string Title { get { return this.title; } }
        public void AddAuhtor(string name)
        {
            this.authors.Add(name);
        }


        public int CompareTo(Book second)
        {
            int yearComperator = this.year.CompareTo(second.Year);
            if (yearComperator == 0)
            {
                return this.title.CompareTo(second.Title);
            }
            return yearComperator;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {this.title} year: {this.year}");
            if (this.authors.Any())
            {
                foreach (var author in this.authors)
                {
                    sb.AppendLine($"  -{author}");
                }
            }
            else
            {
                sb.AppendLine("Anonymous");
            }
            return sb.ToString().TrimEnd();
        }
    }
}