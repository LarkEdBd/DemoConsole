using BOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IStudentBs
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
        Student GetStudent(int studentId);
        bool DeleteStudent(int studentId);
        void UpdateStudent(Student student);
    }
}
