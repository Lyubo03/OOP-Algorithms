using System.Linq;

namespace CollectionHierarchy
{
    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public int Used => stack.Count();
        public override string Remove(int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += $"{stack[0]} ";
                stack.RemoveAt(0);
            }

            return result.TrimEnd(' ');
        }
    }
}