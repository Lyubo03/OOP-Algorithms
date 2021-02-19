namespace CodeFirstDemo.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataValidation.Course;
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<CourseAndStudent> Students { get; set; }
    }
}