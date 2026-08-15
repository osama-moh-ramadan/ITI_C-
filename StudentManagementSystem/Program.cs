using global::StudentManagementSystem.Data;
using StudentManagementSystem.Data;
using System;
using System.Linq;
using StudentManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Application...");

            try
            {
                using var context = new AppDbContext();

             
             
                bool created = context.Database.EnsureCreated();

                if (created)
                {
                    Console.WriteLine(" Database Created Successfully!");
                    Console.WriteLine(" Tables Created!");
                    Console.WriteLine(" Seed Data Inserted!");
                }
                else
                {
                    Console.WriteLine(" Database Already Exists");
                }

                // Display Info
                Console.WriteLine($"\n Database Name: {context.Database.GetDbConnection().Database}");

                var students = context.Students.ToList();
                var courses = context.Courses.ToList();

                Console.WriteLine($"\nTotal Students: {students.Count}");
                Console.WriteLine($"Total Courses: {courses.Count}");

                Console.WriteLine("\n Students List:");
                foreach (var s in students)
                {
                    Console.WriteLine($"  • {s.FullName} | {s.Email} | Age: {s.Age} | %: {s.Percentage}");
                }

                Console.WriteLine("\n Courses List:");
                foreach (var c in courses)
                {
                    Console.WriteLine($"  • {c.Name} | Hours: {c.DurationInHours}");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" ERROR: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}