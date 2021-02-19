namespace Exam1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private List<Student> students;
        public School(string name)
        {
            Name = name;
            students = new List<Student>();
        }
        public School()
        {
            students = new List<Student>();
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
        public List<Student> Students
        {
            get => this.students;
            private set
            {
                this.students = value;
            }
        }
        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            students.Add(student);
        }
        public double AverageResultInRange(int start, int end)
        {
            //if (start < 0)
            //{
            //    start = 0;
            //}
            //if (end >= Students.Count)
            //{
            //    end = Students.Count - 1;
            //}
            double avarage = 0;
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                avarage += this.students[i].Grade;
                counter++;
            }
            return avarage / Math.Abs(end + 1 - (start + 1));
        }
        public List<string> RemoveStudentsByGrade(double grade)
        {
            var result = new List<String>();
            for (int i = 0; i < Students.Count; i++)
            {
                if (students[i].Grade < grade)
                {
                    result.Add(students[i].Name);
                }
            }
            return result;
        }
        public List<Student> SortAscendingByName()
        {
            Students = students.OrderBy(x => x.Name).ToList();
            return Students;
        }
        public List<Student> SortDescendingByGrade()
        {
            Students = students.OrderByDescending(g => g.Grade).ToList();
            return Students;
        }
        public bool CheckStudentIsInSchool(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public string[] ProvideInformationAboutAllStudents()
        {
            string[] studentInf = new string[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                studentInf[i] = students[i].ToString();
            }
            return studentInf;
        }
    }
}