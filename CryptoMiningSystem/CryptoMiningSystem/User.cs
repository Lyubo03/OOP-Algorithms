namespace CryptoMiningSystem
{
    using System;
    public class User
    {
        private string name;
        private double money;
        private Computer computer;

        public User(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(" Username must not be null or empty!");
                }
                this.name = value;
            }
        }

        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }
                this.money = value;
            }
        }
        public Computer Computer
        {
            get => this.computer;
            set
            {
                this.computer = value;
            }
        }
        public int Stars => (int)(this.money / 100);
    }
}