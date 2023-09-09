using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class College
    {
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public List<Professor> Professors = new List<Professor>();
        public List<Department> Departments = new List<Department>();
        public List<Student> Students  = new List<Student>();

        public College(int collegeId, string collegeName)
        {
            CollegeId = collegeId;
            CollegeName = collegeName;
        }

        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public string PrintDetails()
        {
            string details = $"College ID: {CollegeId}, Name: {CollegeName}\n";
            details += "Departments:\n";
            foreach (var department in Departments)
            {
                details += department.ToString() + "\n";
            }
            details += "Professors:\n";
            foreach (var professor in Professors)
            {
                details += professor.ToString() + "\n";
            }
            details += "Students:\n";
            foreach (var student in Students)
            {
                details += student.ToString() + "\n";
            }
            return details;
        }
    }
}
