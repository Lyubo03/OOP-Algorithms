namespace Generics
{
    public class Comperator<T>
    {
        public Comperator()
        {
        }
        public static bool Compare(T first, T second)
        {
            return first.Equals(second);
        }
    }
}