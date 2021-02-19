﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Data.Models
{
    public class Town
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
