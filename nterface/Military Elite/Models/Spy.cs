using Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string name, string lastName, string id, int codeNumber)
            : base(name, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }
        public int CodeNumber { get; }
        public override string ToString()
        {
            return $"Name: {Name} {LastName} Id: {Id}\r\nCode Number: {CodeNumber}";
        }
    }
}
