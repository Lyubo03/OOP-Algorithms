namespace Generics_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
         where T: IComparable 
    {
        private T something;
        private List<T> collection;
        public Box()
        {
            this.collection = new List<T>();
        }
        public void Add(T something)
        {
            collection.Add(something);
        }
        public  void Swap(int[] possitions)
        {

            T temp = this.collection[possitions[0]];
            this.collection[possitions[0]] = this.collection[possitions[1]];
            this.collection[possitions[1]] = temp;
        }
        public int Compare(T element)
        {
            int count = 0;

            foreach (var item in this.collection)
            {
                int itemValue = item.CompareTo(element);
                if (itemValue == 1)
                {
                    count++;
                }
            }

            return count;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            foreach (var item in this.collection)
            {
                res.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return res.ToString().TrimEnd();
        }
    }
}