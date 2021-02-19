using System;
using System.Collections.Generic;
using System.Text;

namespace Paralelepiped
{
    class Paralelepiped
    {
        private double heigth;
        private double width;
        private double length;
        public Paralelepiped(double length, double width, double heigth)
        {
            this.heigth = heigth;
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public double GetHeigth()
        {
            return this.heigth;
        }
        public double GetLength()
        {
            return this.length;
        }
        public double Volume()
        {
            double volume = this.heigth * this.width * this.length;
            return volume;
        }
        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.heigth * this.width + this.heigth * this.length + this.length * this.width);
            return surfaceArea;
        }
        public double LateralSurface()
        {
            double lateralSurface = 2 * (this.length * this.heigth)+ 2*(this.width * this.heigth);
            return lateralSurface;
        }
    }
}
