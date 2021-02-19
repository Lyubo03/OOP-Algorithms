namespace CustomStack
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public MyStack()
        {
            this.stack = new List<T>();
        }

        public void Push(T element)
        {
            this.stack.Add(element);
        }
        public T Pop()
        {
            T element = this.stack[this.stack.Count - 1];
            stack.RemoveAt(this.stack.Count - 1);
            return element;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(this.stack);
            //for (int i = stack.Count - 1; i >= 0; i--)
            //{
            //    yield return stack[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}