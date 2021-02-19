using System;
using System.Collections.Generic;
using System.Text;

namespace StaticBullshit
{
    class Arithmetics
    {
        public static double SquarePerimeter(double side)
        {
            return side * 4;
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
        public static double RectanglePerimeter(double sideA, double sideB)
        {
            return 2 * (sideA + sideB);
        }
        public static double RectangleArea(double sideA, double sideB)
        {
            return sideB * sideA;
        }
        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}

