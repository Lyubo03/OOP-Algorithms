namespace CarsSalesman
{
    using System.Text;
    public class Engine
    {
        private const string offset = "  ";
        public string model;
        public int power;
        private int displacement = -1;
        private string efficiency = "n/a";
        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }
        public int Displacement { get { return this.displacement; } set { this.displacement = value; } }
        public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }
        public string Model { get { return this.model; } }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", offset, this.model);
            sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
            sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.Displacement == -1 ? "n/a" : this.Displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.Efficiency);

            return sb.ToString();
        }
    }
}