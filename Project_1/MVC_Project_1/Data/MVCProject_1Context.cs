using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

namespace Project_1.Data
{
    public class Project_1Context : DbContext
    {
        public Project_1Context (DbContextOptions<Project_1Context> options)
            : base(options)
        {
        }

        public DbSet<Project_1.Models.Course> Course { get; set; }

        public DbSet<Project_1.Models.Student> Student { get; set; }

        public DbSet<Project_1.Models.Teacher> Teacher { get; set; }
        public DbSet<Project_1.Models.Enrollment> Enrollment { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
            .HasOne<Student>(p => p.Student)
            .WithMany(p => p.Courses)
            .HasForeignKey(p => p.StudentId);
            builder.Entity<Enrollment>()
            .HasOne<Course>(p => p.Course)
            .WithMany(p => p.Students)
            .HasForeignKey(p => p.CourseId);
            builder.Entity<Course>()
            .HasOne<Teacher>(p => p.FirstTeacher)
            .WithMany(p => p.Courses)
            .HasForeignKey(p => p.FirstTeacherId);
            builder.Entity<Course>()
            .HasOne<Teacher>(p => p.SecondTeacher)
            .WithMany(p => p.CoursesSec)
            .HasForeignKey(p => p.SecondTeacherId);
        }

    }
}
