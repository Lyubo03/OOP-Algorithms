using System;
using System.Diagnostics.CodeAnalysis;

namespace Equality_Logic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Name.CompareTo(other.Name);
        }
        public override bool Equals(object obj)
        {
            return this.Name == Name && this.Age == ((Person)obj).Age;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode() + (253*53);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}