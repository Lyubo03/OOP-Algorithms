namespace EnumeratorsAndComperators
{
    using System.Collections;

    public class NumbersEnumerator : IEnumerator
    {
        private int[] array;
        private int currentElement;
        public NumbersEnumerator(int[] arr)
        {
            this.Reset();
            array = arr;
        }
        public object Current
        {
            get { return this.array[currentElement]; }
        }

        public bool MoveNext()
        {
            currentElement++;
            return currentElement < array.Length;
        }

        public void Reset()
        {
            currentElement = -1;
        }
    }
}