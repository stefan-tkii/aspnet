using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetProekt.Models
{
    public class MVCSchoolContext : DbContext
    {
        public MVCSchoolContext(DbContextOptions<MVCSchoolContext> options) : base(options)
        {

        }

        public DbSet<Student> student { get; set; }
        public DbSet<Course> course { get; set; }

        public DbSet<Teacher> teacher { get; set; }

        public DbSet<Enrollment> enrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasOne<Teacher>(p => p.FirstTeacher)
                .WithMany(p => p.PrimaryWork).HasForeignKey(p => p.FirstTeacherId);

            modelBuilder.Entity<Course>().HasOne<Teacher>(p => p.SecondTeacher)
                .WithMany(p => p.SecondaryWork).HasForeignKey(p => p.SecondTeacherId);

            modelBuilder.Entity<Enrollment>().HasOne<Course>(p => p.course)
                .WithMany(p => p.AreEnrolled).HasForeignKey(p => p.CourseId);

            modelBuilder.Entity<Enrollment>().HasOne<Student>(p => p.Student)
                .WithMany(p => p.EnrolledOn).HasForeignKey(p => p.StudentId);
        }
    }
}
