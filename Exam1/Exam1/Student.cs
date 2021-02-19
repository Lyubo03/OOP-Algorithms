namespace Exam1
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string name;
        private List<double> grades;
        public Student(string name,double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name
        {
            get => this.name;

            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"Student {Name} has {Grade:F2}.";
        }
    }
}