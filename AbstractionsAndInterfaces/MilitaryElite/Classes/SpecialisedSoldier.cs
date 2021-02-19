namespace MilitaryElite.Classes
{
    using Enums;
    using Interfaces;
    using System;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string firstName, string lastName, int id, decimal salary, Corps corp)
            : base(firstName, lastName, id, salary)
        {
            Corps = corp;
        }

        public Corps Corps { get; private set; }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Corps: {Corps}";
        }
    }
}