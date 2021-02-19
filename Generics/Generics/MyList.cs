using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyList<T> where T : class
    {
        private Stack<T> collection;
        public MyList()
        {
            this.collection = new Stack<T>();
        }
        public void Add(T item)
        {
            var something = new Dog();
            this.collection.Push(item);
        }
        public T Remove()
        {
            return this.collection.Pop();
        }
        public int Count()
        {
            return this.collection.Count;
        }
        public Stack<T> GetCollection { get { return this.collection; } }
    }
}
