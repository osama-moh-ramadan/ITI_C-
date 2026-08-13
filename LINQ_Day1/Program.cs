using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Student> students = StudentData.GetStudents();
            Console.WriteLine("------part 1 : Student Search-------");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.Name == name);

            if (student != null)
            {
                Console.WriteLine("Student Found!");
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Department: {student.Department}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Percentage: {student.Percentage}%");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
            Console.WriteLine("------part 2----------------------");
            var studentsAbove85 = students.Where(s => s.Percentage > 85).OrderByDescending(s => s.Percentage);
            foreach (var studentt in studentsAbove85)
            {
                Console.WriteLine($"{studentt.Name} - {studentt.Percentage}%");
            }
            Console.WriteLine("\n------ Computer Science Students ------");

            var csStudents = students
                .Where(s => s.Department == "Computer Science");

            foreach (var studentt in csStudents)
            {
                Console.WriteLine($"{studentt.Name} - {studentt.Percentage}%");
            }
            Console.WriteLine("\n------ Students Between 80% and 90% ------");

            var studentsBetween80And90 = students
                .Where(s => s.Percentage >= 80 && s.Percentage <= 90);

            foreach (var studentt in studentsBetween80And90)
            {
                Console.WriteLine($"{studentt.Name} - {studentt.Percentage}%");
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("-------------------------part 3:");
            Console.Write("How many top students do you want to display? ");
            int number = int.Parse(Console.ReadLine());
            var topStudents = students.OrderByDescending(s => s.Percentage).Take(number);
            Console.WriteLine($"===== Top {number} Students =====");
            int rank = 1;
            foreach (var studentt in topStudents)
            {
                Console.WriteLine($"{rank}. {studentt.Name} - {studentt.Percentage}%");
                rank++;
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("--------------------------part 4---------------------");
            Console.WriteLine("\n------ Part 4 : Student Pagination ------");

            int pageSize = 3;

            Console.Write("Enter page number: ");
            int pageNumber = int.Parse(Console.ReadLine());

            int skip = (pageNumber - 1) * pageSize;

            var pageStudents = students.Skip(skip).Take(pageSize);
            Console.WriteLine($"===== Page {pageNumber} =====");
            foreach (var studentt in pageStudents)
            {
                Console.WriteLine($"{studentt.Id}. {studentt.Name} - {studentt.Percentage}%");
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("-----------------part 5-----------");
            var departmentGroups = students.GroupBy(s => s.Department);
            Console.WriteLine("===== Students By Department =====");
            foreach (var group in departmentGroups)
            {
                double averagePercentage = group.Average(s => s.Percentage);

                Console.WriteLine($"\n{group.Key}");
                Console.WriteLine($"Students: {group.Count()}");
                Console.WriteLine($"Average Percentage: {averagePercentage:F2}%");
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("----------part 6 -----------------");
            var studentInfo = students.Select(s => new
            {
                s.Name,
                s.Department,
                s.Percentage
            });
            foreach (var studentt in studentInfo)
            {
                Console.WriteLine(
                    $"{studentt.Name} - {studentt.Department} - {studentt.Percentage}%");
            }
            Console.WriteLine("=======================================");
            Console.WriteLine("-----------------part 7-------------");

        }
    }
}
