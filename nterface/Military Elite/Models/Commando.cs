namespace Military_Elite.Models
{
    using Military_Elite.Contracts;
    using Military_Elite.Enums;
    using System.Collections.Generic;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string name, string lastName, string id, decimal salary, Corps corp, ICollection<IMissions> missions)
            : base(name, lastName, id, salary, corp)
        {
            this.Missions = missions;
        }
        public ICollection<IMission> Missions { get; }
    }
}
