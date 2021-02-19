namespace Probmle01
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index;
        public ListyIterator(T[] collection)
        {
            this.index = 0;
            this.list = collection.ToList();
        }
        public bool Move()
        {
            if (MoveNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public object Current => list[index];

        public bool MoveNext()
        {
            return index + 1 < list.Count;
        }
        public string Print()
        {
            return this.list[this.index].ToString();
        }
        public string PrintAll()
        {
            if (!list.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            string res = string.Join(" ", this.list);
            return res;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}