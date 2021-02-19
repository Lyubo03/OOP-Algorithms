namespace LectionAlgo
{
    using System;
    using System.Collections;

    public class ReversedList<T> : IEnumerable
    {
        private T[] elements;
        private const int defaultCapacity = 4;
        private int index;
        private int count = 0;
        public ReversedList()
        {
            this.elements = new T[defaultCapacity];
            this.index = defaultCapacity - 1;
        }
        public T this[int index]
        {

            get
            {
                if (index < 0 || index > Capacity || index < this.index)
                {
                    throw new ArgumentException("Index out of bounds");
                }
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index > Capacity || index < this.index)
                {
                    throw new ArgumentException("Index out of bounds");
                }
                elements[index] = value;
            }
        }
        public int Count => this.count;
        public int Capacity => elements.Length;
        public void Add(T element)
        {
            if (index < 0)
            {
                Resize();
                index = defaultCapacity - 1;
            }

            elements[this.index] = element;
            index--;
            this.count++;
        }

        private void Resize()
        {
            T[] copy = new T[Count + defaultCapacity];
            int counter = defaultCapacity;

            for (int i = 0; i < Count; i++)
            {
                copy[counter] = elements[i];
                counter++;
            }

            this.elements = copy;
        }
        public T RemoveAt(int index)
        {
            if (index > Capacity - 1 || index < 0 || index < this.index)
            {
                throw new ArgumentException("Index out of range!");
            }

            T element = elements[index];
            elements[index] = default(T);

            Shrink(index);
            count--;

            return element;
        }

        private void Shrink(int index)
        {
            T[] copy = new T[Capacity - 1];
            int counter = 0;

            for (int i = 0; i < Capacity; i++)
            {
                if (i != index)
                {
                    copy[counter] = elements[i];
                    counter++;
                }
            }

            this.elements = copy;
        }

        public IEnumerator GetEnumerator()
        {
            if (index == -1)
            {
                index = 0;
            }
            for (int i = index; i < Count; i++)
            {
                yield return elements[i];
            }
        }
    }
}