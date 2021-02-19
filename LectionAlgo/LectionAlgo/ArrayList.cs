namespace LectionAlgo
{
    using System;
    public class ArrayList<T> : ICollect<T>
        where T : struct
    {
        private T[] collection;
        private const int initialLength = 2;
        private int index = 0;

        public int Count => this.collection.Length;

        public T this[int index]
        {
            get => collection[index];
            set
            {
                collection[index] = value;
            }
        }

        public ArrayList()
        {
            this.collection = new T[initialLength];
        }

        public void Add(T element)
        {
            if (index >= Count)
            {
                Resize();
            }

            collection[index] = element;
            index++;
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentException("There is no such possition in the collection");
            }

            T element = collection[index];
            Shrink(index);
            return element;
        }

        private void Shrink(int index)
        {
            T[] shrinked = new T[Count - 1];
            int counter = 0;

            for (int i = 0; i < shrinked.Length; i++)
            {
                if (i != index)
                {
                    shrinked[counter] = collection[i];
                    counter++;
                }
            }

            this.collection = shrinked;
        }

        private void Resize()
        {
            T[] copy = new T[Count + initialLength];

            for (int i = 0; i < collection.Length; i++)
            {
                copy[i] = collection[i];
            }

            this.collection = copy;
        }
    }
}