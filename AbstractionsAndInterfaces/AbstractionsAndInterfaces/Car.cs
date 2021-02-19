namespace Cars
{
    using System;
    public abstract class Car : ICar
    {

        private string model;
        private string color;

        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter a model, idiot!");
                }
                this.model = value;
            }
        }
        public string Color
        {
            get => this.color;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("There is no invisible car!");
                }
                this.color = value;
            }
        }
        public virtual string Start()
        {
            return "Engine start";
        }

        public virtual string Stop()
        {
            return "Breaaak!";
        }
    }
}