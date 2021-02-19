namespace CryptoMiningSystem
{
    public interface IComponent
    {
        string Model { get; }
        double Price { get; }
        double Generation { get; }
        int LifeWorkingHours { get; set; }
    }
}