using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
        }

        public override string ToString()
        {
            return $"student ID: {StudentId}, Name: {StudentId}";
        }
    }
}
