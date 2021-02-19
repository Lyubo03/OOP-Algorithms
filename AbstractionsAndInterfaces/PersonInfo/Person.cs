namespace PersonInfo
{
    using System;
    public abstract class Person : IPerson
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        { 
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set 
            {
                if (value<0)
                {
                    throw new ArgumentException("There is no person with negative age!");
                }
                this.age = value;
            }
        }
    }
}