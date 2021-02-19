namespace BorderControl.LiveObjects
{
    using BorderControl.Interfaces;
    public class Person : IPerson, IBirthable, IIdentifiable
    {
        public Person(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void Buy()
        {
            Food += 10;
        }
        //public override bool Equals(object obj)
        //{
        //    return this.Name == ((Person)obj).Name;
        //}
        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() + (57 * 257);
        //}
    }
}