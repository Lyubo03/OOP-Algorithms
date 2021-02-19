namespace CodeFirstDemo.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataValidation.Student;
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string FirstName { get; set; }

        [MaxLength(NameMaxLength)]
        public string MiddleName { get; set; }

        [MaxLength(NameMaxLength)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public DateTime RegistrationDate { get; set; }

        public StudentType Type { get; set; }

        [NotMapped]
        public string Fullname
        {
            get 
            {
                if (MiddleName == null)
                {
                    return $"{FirstName} {LastName}";
                }
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }
        public int TownId { get; set; }
        public Town Town { get; set; }
        public ICollection<CourseAndStudent> Courses { get; set; }
    }
}