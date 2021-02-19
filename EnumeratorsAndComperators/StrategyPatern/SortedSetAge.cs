namespace StrategyPatern
{
    using System.Collections.Generic;
    using System.Text;

    public class SortedSetAge
    {
        private List<Person> people;

        public SortedSetAge()
        {
            this.people = new List<Person>();
        }
        public void Add(Person person)
        {
            people.Add(person);
        }
        public override string ToString()
        {
            people.Sort(new ComparerAge());
            StringBuilder sb = new StringBuilder();
            foreach (var person in people)
            {
                sb.AppendLine(person.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}