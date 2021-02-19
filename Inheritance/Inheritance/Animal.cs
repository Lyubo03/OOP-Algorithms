using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        private string name;
        private int age;
        private string color;
        public Animal(string name)
        {
            this.name = name;
        }
        public string Name { get => name; }
    }
}
