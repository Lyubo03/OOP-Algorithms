using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Citizen : IPerson
    {
        public Citizen(string name,int age, string id, string birthdate )
        {
            this.age = age;
            this.name = name;
            this.Birthdate = birthdate;
            this.Id = id;
        }

        public int age { get; private set; }
        public string name { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }
    }
}
