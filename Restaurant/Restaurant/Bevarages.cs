namespace Restaurant
{
    public class Bevarage: Product
    {
        public Bevarage(string name, decimal price, double mililitres) 
            : base(name, price)
        {
            this.mililitres = mililitres;
        }
        public double mililitres { get; set; }
    }
}
