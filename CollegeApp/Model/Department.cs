using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Professor> Professors { get; set; } = new List<Professor>();


        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return $"Department ID: {DepartmentId}, Name: {DepartmentName}";
        }
    }
}
