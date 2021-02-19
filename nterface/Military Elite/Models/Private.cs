using Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; private set; }
        public Private(string name, string lastName, string id, decimal salary) 
            : base( name, lastName,id)
        {
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {this.Name} {this.LastName} Id: {this.Id} Salary: {this.Salary}";
        }
    }
}
