using StudentManagementSystem.Configurations;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Configurations;

namespace StudentManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                // ConnectionString صح بناءً على إعداداتك
                "Server=.;Database=StudentManagementDB;" +
                "Trusted_Connection=True;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

            // Seed Data courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C# Programming", Description = "Learn C# basics", DurationInHours = 40 },
                new Course { Id = 2, Name = "ASP.NET Core", Description = "Web development", DurationInHours = 60 },
                new Course { Id = 3, Name = "Entity Framework", Description = "ORM framework", DurationInHours = 30 },
                new Course { Id = 4, Name = "SQL Server", Description = "Database management", DurationInHours = 25 },
                new Course { Id = 5, Name = "Angular", Description = "Frontend framework", DurationInHours = 50 }
            );

            // Seed Data student
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FullName = "Ahmed Mohamed", Email = "ahmed@gmail.com", Age = 20, Percentage = 85.50m },
                new Student { Id = 2, FullName = "Sara Ali", Email = "sara@yahoo.com", Age = 22, Percentage = 90.75m },
                new Student { Id = 3, FullName = "Mohamed Hassan", Email = "moham@hotmail.com", Age = 19, Percentage = 78.00m },
                new Student { Id = 4, FullName = "Nour Khaled", Email = "nour@gmail.com", Age = 21, Percentage = 92.50m },
                new Student { Id = 5, FullName = "Omar Tarek", Email = "omar@outlook.com", Age = 18, Percentage = 65.25m },
                new Student { Id = 6, FullName = "Yasmin Samir", Email = "yasmin@gmail.com", Age = 23, Percentage = 88.00m },
                new Student { Id = 7, FullName = "Kareem Adel", Email = "kareem@yahoo.com", Age = 20, Percentage = 72.50m },
                new Student { Id = 8, FullName = "Hana Ibrahim", Email = "hana@gmail.com", Age = 17, Percentage = 95.00m },
                new Student { Id = 9, FullName = "Ziad Mahmoud", Email = "ziad@hotmail.com", Age = 25, Percentage = 60.75m },
                new Student { Id = 10, FullName = "Dina Fathy", Email = "dina@gmail.com", Age = 16, Percentage = 83.25m }
            );
        }
    }
}