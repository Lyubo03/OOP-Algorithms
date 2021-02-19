namespace CollectionHierarchy
{
    using System.Collections.Generic;
    public class AddCollection<T> : IAddCollection
    {
        private List<T> list;
        public AddCollection()
        {
            list = new List<T>();
        }
        public List<T> Collection { get; }
        public string Add(T[] elements)
        {
            string result = null;

            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(elements[i]);
                result += $"{i} ";
            }

            return result.TrimEnd(' ');
        }
    }
}