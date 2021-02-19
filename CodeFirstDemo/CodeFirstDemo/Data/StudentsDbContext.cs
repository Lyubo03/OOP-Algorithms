namespace CodeFirstDemo.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using CodeFirstDemo.Migrations;

    public class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<CourseAndStudent> CourseAndStudents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-2RO7KG1\SQLEXPRESS;Database=StudentsCodeFirst;Integrated Security=true"); 
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Student>()
                .HasOne(st => st.Town)
                .WithMany(t => t.Students)
                .HasForeignKey(st => st.TownId);

            modelBuilder.Entity<CourseAndStudent>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<CourseAndStudent>()
                .HasOne(sc => sc.Student)
                .WithMany(c => c.Courses)
                .HasForeignKey(s => s.StudentId);

            modelBuilder
                .Entity<CourseAndStudent>()
                .HasOne(sc => sc.Course)
                .WithMany(sc => sc.Students)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}
