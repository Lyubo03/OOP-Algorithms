namespace CryptoMiningSystem.Components
{
    using System;
    using Interfaces;
    public class HighPerformanceProcessor : Component, IProcessor
    {
        public HighPerformanceProcessor(string model, double price, double generation)
            : base(model, price, generation)
        {
        }
        public int MineMultiplier => 8;
    }
}