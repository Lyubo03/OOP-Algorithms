namespace ConsoleApp2
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }
        public int Age{ get { return this.age; } }
        public string Name { get { return this.name; } }
        public string Town { get { return this.town; } }

        public int CompareTo(Person other)
        {
            if (this.town.CompareTo(other.Town) == 0)
            {
                if (this.age.CompareTo(other.Age) == 0)
                {
                    return this.name.CompareTo(other.Name);
                }
                return this.age.CompareTo(other.Age);
            }
            return this.town.CompareTo(other.Town);
        }
    }
}