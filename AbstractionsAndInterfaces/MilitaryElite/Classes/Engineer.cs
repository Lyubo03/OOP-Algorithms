namespace MilitaryElite.Classes
{
    using MilitaryElite.Enums;
    using MilitaryElite.Interfaces;
    using MilitaryElite.Tools;
    using System;
    using System.Collections.Generic;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, int id, decimal salary, Corps corp)
            : base(firstName, lastName, id, salary, corp)
        {
            Repairs = new List<Repair>();
        }

        public ICollection<Repair> Repairs { get; private set; }
        public void AddRepair(Repair repair)
        {
            Repairs.Add(repair);
        }
        public override string ToString()
        {
            string info = base.ToString() + Environment.NewLine;
            info += "Repairs:";
            foreach (var repair in Repairs)
            {
                info += Environment.NewLine;
                info += $"  {repair}";
            }
            return info;
        }
    }
}