using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class StudentBs : IStudentBs
    {

        private IStudentDb db;
        private int studentIdCounter;

        public StudentBs()
        {
            studentIdCounter = 1;
            db = new StudentDb();
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
