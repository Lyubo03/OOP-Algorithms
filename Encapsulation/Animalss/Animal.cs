namespace Animalss
{
    using System;
    using System.Text;
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            if (name == null)
            {
                throw new InvalidOperationException("Invalid input!");
            }
            Name = name;

            if (age < 0)
            {
                throw new InvalidOperationException("Invalid input!");
            }
            Age = age;

            if (gender == null)
            {
                throw new InvalidOperationException("Invalid input!");
            }
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual string ProduceSound()
        {
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine(ProduceSound());
            return sb.ToString().TrimEnd();
        }
    }
}