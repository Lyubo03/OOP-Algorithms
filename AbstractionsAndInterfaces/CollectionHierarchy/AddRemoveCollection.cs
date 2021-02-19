

namespace CollectionHierarchy
{
    using System.Collections.Generic;
    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        public List<T> stack;
        public AddRemoveCollection()
        {
            stack = new List<T>();
        }
        public Stack<string> AddRemCollection { get; }
        public virtual string Remove(int n)
        {
            string result = null;
            for (int i = stack.Count - 1; n > 0; i--, n--)
            {
                result += $"{stack[i]} ";
                stack.RemoveAt(i);
            }
            return result.TrimEnd();
        }
        public string Add(T[] elements)
        {
            string result = string.Empty;

            for (int i = 0; i < elements.Length; i++)
            {
                result += $"{0} ";
                stack.Add(elements[i]);
                if (i > 0)
                {
                    for (int w = stack.Count - 1; w > 0; w--)
                    {
                        T temp = stack[w - 1];
                        stack[w - 1] = stack[w];
                        stack[w] = temp;
                    }

                }
            }

            return result.TrimEnd(' ');
        }
    }
}