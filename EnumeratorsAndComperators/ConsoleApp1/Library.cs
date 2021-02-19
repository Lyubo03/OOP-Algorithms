namespace BookLibrary
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;
        public Library()
        {
            this.books = new SortedSet<Book>(new BookComperator());
        }
        public void AddBook(Book book)
        {
            this.books.Add(book);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new BookIterator(this.books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        public class BookIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public BookIterator(List<Book> books)
            {
                Reset();
                this.books = books;
            }
            public Book Current
            {
                get { return this.books[index]; }
            }

            object IEnumerator.Current => this.Current;

            public bool MoveNext()
            {
                this.index++;

                return this.index < books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
            public void Dispose()
            {
            }
        }
    }
}