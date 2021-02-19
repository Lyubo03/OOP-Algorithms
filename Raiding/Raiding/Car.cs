using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Car : ICar
    {
        public string Model
        {
            get { return Model; }
            set { Model = value; }
        }

        public string Color
        {
            get { return Color; }
            set { Color = value; }
        }

        public int age
        {
            get { return age; }
            set { age = value; }
        }

        public abstract string Start();
        public abstract string Stop();
    }
}
