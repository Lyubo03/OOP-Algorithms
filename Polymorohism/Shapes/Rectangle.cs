using System.Globalization;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double Height => this.height;
        public double Width => this.width;
        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return width * 2 + height * 2;
        }
        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}