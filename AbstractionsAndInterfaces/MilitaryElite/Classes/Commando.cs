namespace MilitaryElite.Classes
{
    using MilitaryElite.Enums;
    using MilitaryElite.Interfaces;
    using MilitaryElite.Tools;
    using System;
    using System.Collections.Generic;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string firstName, string lastName, int id, decimal salary, Corps corp)
            : base(firstName, lastName, id, salary, corp)
        {
            Missions = new List<IMission>();
        }
        public ICollection<IMission> Missions { get; private set; }
        public void AddMissions(Mission mission)
        {
            Missions.Add(mission);
        }
        public override string ToString()
        {
            string info = $"{base.ToString()}{Environment.NewLine}Missions:";
            foreach (var mission in Missions)
            {
                info += Environment.NewLine;
                info += $"  {mission}";
            }
            return info;
        }
    }
}