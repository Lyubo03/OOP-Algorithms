namespace CustomStack
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private List<T> stack;
        private int index;
        public StackEnumerator(List<T> stack)
        {
            this.stack = stack;
            Reset();
        }
        object IEnumerator.Current => throw new System.NotImplementedException();

        public T Current => this.stack[this.index];

        public bool MoveNext()
        {
            return --this.index >-1;
        }

        public void Reset()
        {
            this.index = stack.Count();
        }
        public void Dispose()
        {
        }
    }
}