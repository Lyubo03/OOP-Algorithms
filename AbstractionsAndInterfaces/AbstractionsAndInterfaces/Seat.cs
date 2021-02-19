namespace Cars
{
    using System.Text;
    public class Seat : Car, ICar
    {
        public Seat(string model, string color) 
            : base(model, color)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Seat {this.Model}");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString().TrimEnd();
        }
    }
}