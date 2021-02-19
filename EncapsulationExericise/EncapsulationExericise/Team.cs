namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    public class Team
    {
        private string name;
        private List<Person> mainTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            mainTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }
        public string Name { get { return this.name; } }
        public IReadOnlyCollection<Person> FirstTeam { get { return this.mainTeam.AsReadOnly(); } }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                mainTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
        public override string ToString()
        {
            return $"First team has {mainTeam.Count} players.{Environment.NewLine}Reserve team has {reserveTeam.Count} players.";
        }
    }
}