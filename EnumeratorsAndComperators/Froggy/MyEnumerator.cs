namespace Froggy
{
    using System.Collections.Generic;
    public class MyEnumerator : IEnumerator<int>
    {
        private int index;
        private int[] data;

        public MyEnumerator(int[] data)
        {
            Reset();
            this.data = data;
        }

        public object Current => this.data[this.index];

        int IEnumerator<int>.Current => this.data[this.index];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.index += 2;
            return this.index < this.data.Length;
        }

        public void Reset()
        {
            this.index = -2;
        }
    }
}