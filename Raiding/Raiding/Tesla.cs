using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Tesla : Car, IElectromobile
    {
        public Tesla(string model, int age, string color)
        {
            this.Model = model;
            this.age = age;
            this.Color = color;
        }

        public int Battery
        {
            get { return Battery; }
            set { this.Battery = value; }
        }

        public string IntroduceYourself()
        {
            return $"Model: {Model}, Age: {age}, Color: {Color}";
        }

        public override string Start()
        {
            return "Does not make any sound!";
        }

        public override string Stop()
        {
            return "Does not make brumBrum";
        }
    }
}
