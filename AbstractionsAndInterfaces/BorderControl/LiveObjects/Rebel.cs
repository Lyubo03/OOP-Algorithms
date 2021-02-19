namespace BorderControl.LiveObjects
{
    using BorderControl.Interfaces;
    public class Rebel : IRebel
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public string Group { get; private set; }

        public void Buy()
        {
            Food += 5;
        }
        //public override bool Equals(object obj)
        //{
        //    return this.Name == ((Rebel)obj).Name;
        //}
        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() + (57 * 257);
        //}
    }
}