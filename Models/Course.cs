using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt.Models
{
    public class Course
    {
        public Course() { }
        public int Id { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [Required]
        public int Semester { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [MaxLength(100)]
#nullable enable
        public string? Programme { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [MaxLength(25)]
#nullable enable
        public string? EducationLevel { get; set; }


        public int? FirstTeacherId { get; set; }
        public Teacher FirstTeacher { get; set; }

        public int? SecondTeacherId { get; set; }
        public Teacher SecondTeacher { get; set; }

        public ICollection<Enrollment> AreEnrolled { get; set; }
    }
}