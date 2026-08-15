using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // VARCHAR مش NVARCHAR وmax length 150
        public string Description { get; set; }

        public int DurationInHours { get; set; }
    }
}