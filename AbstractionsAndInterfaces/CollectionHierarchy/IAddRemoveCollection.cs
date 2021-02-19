namespace CollectionHierarchy
{
    public interface IAddRemoveCollection<T> : IAddCollection
    {
        public string Remove(int n);
    }
}