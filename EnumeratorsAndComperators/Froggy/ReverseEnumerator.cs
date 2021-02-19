namespace Froggy
{
    using System.Collections.Generic;

    public class ReverseEnumerator : IEnumerator<int>
    {
        private int index;
        private int[] data;

        public ReverseEnumerator(int[] data)
        {
            this.data = data;
            Reset();
        }

        public object Current => this.data[this.index];

        int IEnumerator<int>.Current => this.data[this.index];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index -= 2;
            return this.index >= 0;
        }

        public void Reset()
        {
            if (this.data.Length % 2 == 0)
            {
                this.index = data.Length + 1;
            }
            else
            {
                this.index = data.Length;
            }
        }
    }
}