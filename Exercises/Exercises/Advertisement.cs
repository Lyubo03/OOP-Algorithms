using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class Advertisement
    {
        private string[] phrase = new string[]{ "Excellent product.",
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can’t live without this product."  };
        private string[] eventName = new string[] { "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!" };
        private string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        private string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        public string[] Phrase
        {
            get { return this.phrase; }
        }
        public string[] Event
        {
            get { return eventName; }
        }
        public string[] Author
        {
            get { return author; }
        }
        public string[] City
        {
            get { return city; }
        }
        public string GenerateAdv()
        {
            string result = string.Empty;
            Random r = new Random();
            int phrase = r.Next(0, Phrase.Length);
            int eventName = r.Next(0, Event.Length);
            int author = r.Next(0, Author.Length);
            int city = r.Next(0, City.Length);
            while (phrase != eventName && phrase != author && eventName != author && city != phrase && city != author)
            {
                phrase = r.Next(0, Phrase.Length); eventName = r.Next(0, Event.Length); author = r.Next(0, Author.Length); city = r.Next(0, City.Length);
            }
            result = $"{Phrase[phrase]} {Event[eventName]} {Author[author]} - {City[city]}";
            return result;
        }
    }
}
