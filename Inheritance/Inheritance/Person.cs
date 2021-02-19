using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null) throw new Exception("You should write a proper name!");
                this.name = value;
            }
        }
        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
