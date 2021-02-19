namespace CryptoMiningSystem.Components
{
    using Interfaces;
    using System;

    public abstract class VideoCard : Component
    {
        private int ram;
        public VideoCard(string model, double generation, int ram, double price)
            : base(model, generation, price)
        {
            Ram = ram;
        }

        public int Ram
        {
            get => this.ram;
            private set
            {
                if (0 > value || value <= 32)
                {
                    throw new ArgumentException($"{typeof(VideoCard).Name} ram cannot less or equal to 0 and more than 32!");
                }
                this.ram = value;
            }
        }

        public double MinedMoneyPerHour => this.Ram * this.Generation * 10;
    }
}