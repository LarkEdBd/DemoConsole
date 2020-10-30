using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class StudentManager : IStudentManager
    {

        private IStudentRepository db;
        private int studentIdCounter;

        public StudentManager()
        {
            studentIdCounter = 1;
            db = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return db.GetStudents();
        }

        public void AddStudent(Student student)
        {
            student.StudentId = studentIdCounter;
            db.AddStudent(student);
            studentIdCounter++;
        }

        public Student GetStudent(int studentId)
        {
            return db.GetStudent(studentId);
        }

        public bool DeleteStudent(int studentId)
        {
            return db.DeleteStudent(studentId);
        }

        public void UpdateStudent(Student student)
        {
            db.UpdateStudent(student);
        }
    }
}
