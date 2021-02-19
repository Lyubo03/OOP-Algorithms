using Military_Elite.Contracts;
using Military_Elite.Enums;
using System;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string name, string lastName, string id, decimal salary, Corps corp)
            : base(name, lastName, id, salary)
        {
            this.Corps = corp;
        }

        public Corps Corps { get; }

    }
}
