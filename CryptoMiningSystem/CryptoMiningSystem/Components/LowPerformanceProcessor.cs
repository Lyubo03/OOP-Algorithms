namespace CryptoMiningSystem.Components
{
    using CryptoMiningSystem.Interfaces;

    public class LowPerformanceProcessor : Component, IProcessor
    {
        public LowPerformanceProcessor(string model, double price, double generation)
            : base(model, price, generation)
        {
        }

        public int MineMultiplier => 2;
    }
}