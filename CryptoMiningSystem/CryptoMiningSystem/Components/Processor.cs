namespace CryptoMiningSystem.Components
{
    using System;
    using Interfaces;
    public class Processor : Component
    {
        public Processor(string model, double price, double generation) 
            : base(model, price, generation)
        {
        }

        public override double Generation
        {
            get => base.Generation;
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"{GetType().Name} generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
    }
}