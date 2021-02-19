using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks.Sources;

namespace Articles
{
    public class Article
    {
        private string title;
        private string content;
        private string author;
        public Article(string title, string content, string author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
        }
        public string Title { get { return title; }}
        public string Content { get { return content; } }
        public string Author { get { return author; } }
        public void Edit(string newContent)
        {
            this.content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}