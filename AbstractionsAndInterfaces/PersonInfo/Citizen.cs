using System;
using System.Data;

namespace PersonInfo
{
    public class Citizen : Person, IIdentifiable
    {
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            Birthdate = birthdate;
            Id = id;
        }

        public string Id
        {
            get => this.id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value cannot be null");
                }
                this.id = value;
            }
        }
        public string Birthdate
        {
            get => this.birthdate;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value cannot be null");
                }
                this.birthdate = value; 
            }
        }
    }
}