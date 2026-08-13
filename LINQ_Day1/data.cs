using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Day1
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public double Percentage { get; set; }
        public List<string> Skills { get; set; }
    }

    public static class StudentData
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Ahmed Ali",
                    Department = "Computer Science",
                    Age = 21,
                    Percentage = 92.5,
                    Skills = new List<string> { "C#", "SQL", "ASP.NET Core" }
                },

                new Student
                {
                    Id = 2,
                    Name = "Mona Hassan",
                    Department = "Information Systems",
                    Age = 22,
                    Percentage = 87.4,
                    Skills = new List<string> { "SQL", "Excel", "Power BI" }
                },

                new Student
                {
                    Id = 3,
                    Name = "Omar Mohamed",
                    Department = "Computer Science",
                    Age = 20,
                    Percentage = 95.8,
                    Skills = new List<string> { "C#", "Java", "Problem Solving" }
                },

                new Student
                {
                    Id = 4,
                    Name = "Sara Ahmed",
                    Department = "Information Systems",
                    Age = 21,
                    Percentage = 78.6,
                    Skills = new List<string> { "SQL", "HTML", "CSS" }
                },

                new Student
                {
                    Id = 5,
                    Name = "Youssef Khaled",
                    Department = "Information Technology",
                    Age = 23,
                    Percentage = 89.2,
                    Skills = new List<string> { "Networking", "Linux", "Python" }
                },

                new Student
                {
                    Id = 6,
                    Name = "Nour Adel",
                    Department = "Computer Science",
                    Age = 20,
                    Percentage = 96.4,
                    Skills = new List<string> { "C#", "ASP.NET Core", "Entity Framework" }
                },

                new Student
                {
                    Id = 7,
                    Name = "Karim Samir",
                    Department = "Information Technology",
                    Age = 22,
                    Percentage = 73.5,
                    Skills = new List<string> { "Networking", "Windows Server", "Linux" }
                },

                new Student
                {
                    Id = 8,
                    Name = "Hana Mahmoud",
                    Department = "Information Systems",
                    Age = 21,
                    Percentage = 91.3,
                    Skills = new List<string> { "SQL", "Power BI", "Excel" }
                },

                new Student
                {
                    Id = 9,
                    Name = "Ali Mostafa",
                    Department = "Computer Science",
                    Age = 23,
                    Percentage = 84.7,
                    Skills = new List<string> { "C++", "Data Structures", "Algorithms" }
                },

                new Student
                {
                    Id = 10,
                    Name = "Salma Tarek",
                    Department = "Information Technology",
                    Age = 20,
                    Percentage = 94.1,
                    Skills = new List<string> { "Python", "Cyber Security", "Linux" }
                },

                new Student
                {
                    Id = 11,
                    Name = "Mahmoud Adel",
                    Department = "Computer Science",
                    Age = 22,
                    Percentage = 76.8,
                    Skills = new List<string> { "Java", "C++", "Problem Solving" }
                },

                new Student
                {
                    Id = 12,
                    Name = "Laila Hassan",
                    Department = "Information Systems",
                    Age = 23,
                    Percentage = 88.9,
                    Skills = new List<string> { "SQL", "Business Analysis", "Excel" }
                }
            };
        }
    }
}



