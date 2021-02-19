using System.Runtime.CompilerServices;

namespace Generics
{
    public class EqualityScale<T> where T : struct 
    {
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }
        public T Left { get; set; }
        public T Right { get; set; }

        public bool AreEqual {get { return this.Left.Equals(this.Right); }}
    }
}
