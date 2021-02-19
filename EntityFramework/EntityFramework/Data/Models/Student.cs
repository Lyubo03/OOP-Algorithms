namespace EntityFramework.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.Student;
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLenght)]
        public string FirstName { get; set; }
        [MaxLength(NameMaxLenght)]
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime RegistrationDate { get; set; }
        public StudentType Type { get; set; }
    }
}