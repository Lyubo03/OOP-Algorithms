namespace Cars
{
    using System.Text;
    public class Tesla : ElectricCar
    {
        public Tesla(string model, string color, int batteries)
            : base(model, color, batteries)
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Tesla {this.Model} with {Batteries} Batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }
    }
}