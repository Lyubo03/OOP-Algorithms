namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    public class Team
    {
        private string name;
        private List<Person> mainTeam;
        private List<Person> reserveTeam;
        private const int delimiter = 40;
        public Team(string name)
        {
            this.name = name;
            mainTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }
        public void AddPlayer(Person person)
        {
            if (person.Age >= delimiter)
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
            return $"Main team count: {mainTeam.Count}{Environment.NewLine}Reserve team count: {reserveTeam.Count}";
        }
    }
}