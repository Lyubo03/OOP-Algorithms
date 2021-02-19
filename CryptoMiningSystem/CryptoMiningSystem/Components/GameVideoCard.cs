namespace CryptoMiningSystem.Components
{
    using Interfaces;
    using System;

    public class GameVideoCard : VideoCard, IVideoCard
    {
        public GameVideoCard(string model, double generation, int ram, double price)
            : base(model, generation, ram, price)
        {
        }
        public override double Generation
        {
            get => base.Generation;
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Game video card generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
    }
}