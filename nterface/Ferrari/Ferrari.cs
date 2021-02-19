using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : Icar
    {
        public Ferrari(string driver, string model)
        {
            Driver = driver;
            Model = model;
        }

        public string Driver { get; private set; }
        public string Model { get; private set; }
        
        public string Gas()
        {
            return "Gass!";
        }
        public string Brakes()
        {
            return "Brakess!";
        }
        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
        }
    }
}
