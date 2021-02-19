namespace BookLibrary
{
    using System.Collections.Generic;

    public class BookComperator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int nameComperator = x.Title.CompareTo(y.Title);

            if (nameComperator == 0)
            {
                return y.Year.CompareTo(x.Year);
            }

            return nameComperator;
        }
    }
}