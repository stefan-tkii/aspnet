using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt.Models
{
    public class Enrollment
    {
        public Enrollment() { }
        public Int64 Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course course { get; set; }

        [Required]
        public Int64 StudentId { get; set; }
        public Student Student { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [MaxLength(10)]
#nullable enable
        public string? Semester { get; set; }

        public int? Year { get; set; }

        public int? Grade { get; set; }

        [MaxLength(255)]
#nullable enable
        public string? SeminalUrl { get; set; }

        [MaxLength(255)]
#nullable enable
        public string? ProjectUrl { get; set; }

        public int? ExamPoints { get; set; }

        public int? SeminalPoints { get; set; }

        public int? ProjectPoints { get; set; }

        public int? AdditionalPoints { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FinishDate { get; set; }
    }
}
