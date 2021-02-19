namespace StrategyPatern
{
    using System.Collections.Generic;
    using System.Text;

    public class SortedSetName
    {
        private List<Person> people;

        public SortedSetName()
        {
            this.people = new List<Person>();
        }
        public void Add(Person person)
        {
            people.Add(person);
        }
        public override string ToString()
        {
            people.Sort(new ComparerName());
            StringBuilder sb = new StringBuilder();
            foreach (var person in people)
            {
                sb.AppendLine(person.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}