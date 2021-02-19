namespace CryptoMiningSystem.Interfaces
{
    public interface IProcessor : IComponent
    {
        int MineMultiplier { get; }
    }
}