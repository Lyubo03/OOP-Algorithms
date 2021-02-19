namespace LectionAlgo
{
    public interface ICollect<T>
    {
        public int Count{ get; }
        public void Add(T element);
    }
}