namespace BoxData
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, heigth);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}" +
                $"{Environment.NewLine}Lateral Surface Area - {box.LateralSurfaceArea():F2}{Environment.NewLine}" +
                $"Volume - {box.Volume():F2}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}