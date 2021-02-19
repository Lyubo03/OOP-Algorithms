namespace CryptoMiningSystem.Interfaces
{
    public interface IVideoCard : IComponent
    {
        int Ram { get; }
        double MinedMoneyPerHour { get; }
    }
}