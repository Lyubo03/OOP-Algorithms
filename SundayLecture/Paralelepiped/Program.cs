using System;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            Paralelepiped paralelepiped = new Paralelepiped(length, width, heigth);
            Console.WriteLine($"Volume: {paralelepiped.Volume()}");
            Console.WriteLine($"Surface: {paralelepiped.SurfaceArea()}");
            Console.WriteLine($"Lateral Surface Area: {paralelepiped.LateralSurface()}");
        }
    }
}
