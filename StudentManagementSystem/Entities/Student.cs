using System;
using System.Collections.Generic;
using System.Text;


namespace StudentManagementSystem.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public decimal Percentage { get; set; }
    }
}