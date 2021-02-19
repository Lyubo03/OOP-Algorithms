namespace CryptoMiningSystem.Components
{
    using Interfaces;
    using System;
    public class MineVideoCard : VideoCard, IVideoCard
    {
        public MineVideoCard(string model, double generation, int ram, double price)
            : base(model, generation, ram, price)
        {
        }

        public override double Generation
        {
            get => base.Generation;
            set
            {
                if (value > 6)
                {
                    throw new ArgumentException("Mine video card generation cannot be more than 6!");
                }
                base.Generation = value;
            }
        }
    }
}