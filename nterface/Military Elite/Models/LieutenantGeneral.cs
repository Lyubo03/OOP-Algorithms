using Military_Elite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public Dictionary<int,IPrivate> Privates { get; private set; }
        public LieutenantGeneral( string name, string lastName,string id, decimal salary, Dictionary<int, IPrivate> privates)
            : base(name, lastName,id, salary)
        {
            this.Privates = privates;
        }
        public override string ToString()
        {
            return $"Name: {Name} {LastName} Id: {Id} Salary: {Salary}\r\nPrivates:\r\n + {PrintPrivates()}";            
        }
        public string PrintPrivates()
        {
            string result = string.Empty;
            foreach (var kvp in Privates)
            {
                result += kvp.Value.ToString() + "\r\n";
            }
            return result;
        }
    }
}
