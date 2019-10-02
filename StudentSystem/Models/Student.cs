using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public string CourseCode { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public double Gpa { get; set; }
        public bool FullTime { get; set; }
        public int StudentId { get; set; }

    }
}
