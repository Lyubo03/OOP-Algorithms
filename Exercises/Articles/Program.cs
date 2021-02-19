using System;
using System.Collections.Generic;
using System.Linq;
namespace Articles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(':');
                switch (input[0].ToLower())
                {
                    case "edit": article.Edit(input[1].TrimStart(' ')); break;
                    case "changeauthor": article.ChangeAuthor(input[1].TrimStart(' ')); break;
                    case "rename": article.Rename(input[1].TrimStart(' ')); break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}