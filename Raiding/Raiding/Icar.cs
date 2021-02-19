using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        int age { get; }
        string Start();
        string Stop();
        public string IntroduceYourself()
        {
            return $"Model: {Model}, Age: {age}, Color: {Color}";
        }
    }
}
