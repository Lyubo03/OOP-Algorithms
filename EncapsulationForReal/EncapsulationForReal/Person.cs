namespace PersonsInfo
{
    using System;
    public class Person
    {
        public Person(string name, string lastName, int age, decimal salary)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {

            set => FirstName = value ?? throw new InvalidOperationException("First name cannot contain fewer than 3 symbols!");
            get => FirstName;
        }
        public string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new InvalidOperationException("Last name cannot contain fewer than 3 symbols!");
                }
                FirstName = value;
            }
            get => LastName;
        }
        public int Age
        {
            set
            {
                if (value < 1)
                {
                    throw new InvalidOperationException("Age cannot be zero or a negative integer!");
                }
            }
            get => Age;
        }
        public decimal Salary
        {
            set
            {
                if (value < 460)
                {
                    throw new InvalidOperationException("Salary cannot be less than 460 leva!");
                }
            }
            get => Salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            int delimiter = 100;
            if (Age < 30)
            {
                delimiter *= 2;
            }
            Salary += Salary * percentage / delimiter;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }
    }
}