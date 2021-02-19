using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private string familyname;
        private int years;
        private double salary;
        public Person(string name, string familyname, int years, double salary)
        {
            if (name.Length<3)
            {
                throw new Exception("More symbols needed.");
            }
            else
            {
            this.name = name;
            }
            this.familyname = familyname;
            this.years = years;
            if (salary < 460)
            {
                throw new FieldAccessException("Boiko pogledni zaplatite");
            }
            else
            {
                this.salary = salary;
            }
        }
        public double GetSalary()
        {
            return this.salary;
        }
        public string GetFamilyName()
        {
            return this.familyname;
        }
        public string GetName()
        {
            return name;
        }
        public int GetYears()
        {
            return this.years;
        }
        public void IncreaseBonus(double bonus)
        {
            if (years < 30)
            {
                bonus /= 2;
            }
            this.salary += salary / 100 * bonus;
        }
        public string IntroducePerson()
        {
            string result = $"{this.name} {this.familyname} get {this.salary:F2} leva.";
            return result;
        }
    }
}
