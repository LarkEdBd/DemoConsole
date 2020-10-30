using BOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
        Student GetStudent(int studentId);
        bool DeleteStudent(int studentId);
        void UpdateStudent(Student student);
    }
}
