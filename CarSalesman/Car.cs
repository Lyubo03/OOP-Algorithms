namespace CarsSalesman
{
    using System.Text;
    public class Car
    {
        private const string offset = "  ";
        private int weight = -1;
        private string model;
        public Car(string model, Engine engine)
        {
            this.model = model;
            this.CarEngine = engine;
        }
        public int Weight { get { return this.weight; } set { this.weight = value; } }
        public string Color { get; set; }
        public Engine CarEngine { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.model);
            sb.Append(this.CarEngine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.Weight == -1 ? "n/a" : this.Weight.ToString());
            sb.AppendFormat("{0}Color: {1}", offset, this.Color);

            return sb.ToString();
        }
    }
}