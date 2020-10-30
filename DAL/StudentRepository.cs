using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student GetStudent(int studentId)
        {
            return _students.Where(s => s.StudentId == studentId).FirstOrDefault();
        }

        public bool DeleteStudent(int studentId)
        {
            var student = GetStudent(studentId);

            if (student != null)
            {
                _students.Remove(student);
                return true;
            }

            return false;
        }

        public void UpdateStudent(Student student)
        {
            DeleteStudent(student.StudentId);
            AddStudent(student);
        }
    }
}
