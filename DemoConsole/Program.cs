using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentManager bs = new StudentManager();

            Student student = new Student();
            student.FirstName = "Sazzadul";
            student.LastName = "Karim";

            bs.AddStudent(student);

            var students = bs.GetStudents();

            foreach (var std in students)
            {
                Console.WriteLine($"Name: { std.FullName }");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
