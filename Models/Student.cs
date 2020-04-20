using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetProekt.Models
{
    public class Student
    {
        public Student() { }

        public Int64 Id { get; set; }

        [MaxLength(10)]
        [MinLength(4)]
        [RegularExpression("^[0-9]*$")]
        [Required]
        public string Indeks { get; set; } // studentId najlogicno e da bide indeksot vsusnost vo format bez kosa crta primer 2702017

        [StringLength(50)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [Required]
        public string FirstName { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int? AcquiredCredits { get; set; }

        public int? CurrentSemester { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [StringLength(25)]
#nullable enable
        public string? EducationLevel { get; set; }

        public ICollection<Enrollment> EnrolledOn { get; set; }
    }
}
