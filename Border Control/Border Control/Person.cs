using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Person : IPerson
    {
        public Person(string name, int age, long id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Name { get; }

        public int Age { get; }

        public long Id { get; }
    }
}
