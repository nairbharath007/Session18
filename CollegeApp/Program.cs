using CollegeApp.Model;

namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College(1, "College1");

            Department department1 = new Department(101, "CS");
            Department department2 = new Department(102, "IT");
            college.AddDepartment(department1);
            college.AddDepartment(department2);


            Professor professor1 = new Professor(201, "Prof1");
            Professor professor2 = new Professor(202, "Prof2");
            college.AddProfessor(professor1);
            college.AddProfessor(professor2);

            Student student1 = new Student(301, "Student1");
            Student student2 = new Student(302, "Student2");
            college.AddStudent(student1);
            college.AddStudent(student2);

            Console.WriteLine(college.PrintDetails());

        }
    }
}