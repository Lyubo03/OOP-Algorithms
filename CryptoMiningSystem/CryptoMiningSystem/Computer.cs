namespace CryptoMiningSystem
{
    using Interfaces;
    using System;

    public class Computer
    {
        private IProcessor processor;
        private IVideoCard videoCard;
        private int ram;

        public Computer(IProcessor processor, IVideoCard videoCard)
        {
            Processor = processor;
            VideoCard = videoCard;
            Ram = ram;
        }
        public int Ram
        {
            get => this.ram;

            private set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                }
                this.ram = value;
            }
        }
        public IVideoCard VideoCard { get; private set; }
        public IProcessor Processor { get; private set; }
        private double MinedAmountPerHour => this.videoCard.MinedMoneyPerHour * this.processor.MineMultiplier; 
    }
}