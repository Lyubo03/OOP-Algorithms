namespace EnumeratorsAndComperators
{
    using System.Collections;

    public class Numbers : IEnumerable
    {
        private int[] collection;
        private IEnumerator enumerator;
        public Numbers(int[] collection)
        {
            this.collection = collection;
            this.enumerator = new NumbersEnumerator(collection);
        }
        public IEnumerator GetEnumerator()
        { 
            return this.enumerator;
        }
    }
}