namespace CodeFirstDemo
{
    using CodeFirstDemo.Data;
    using Microsoft.EntityFrameworkCore;
    using Data.Models;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new StudentsDbContext();
            db.Database.Migrate();

            var coursePiene = new Course() { Description ="Bar nazdrave", Name = "Piene do dyno" };


            var studentId = db.Students.Select(st => st.Id).FirstOrDefault();

            db.CourseAndStudents.Add(new CourseAndStudent
            {
                StudentId = studentId,
                CourseId = db.Courses.Select(c => c.Id).First()
            });

            db.SaveChanges();
        }
    }
}