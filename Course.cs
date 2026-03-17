using System;
using System.Collections.Generic;
using System.Linq;

namespace Jiratchot
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Teacher CourseInstructor { get; set; }

        private List<Student> _students;

        public Course(string courseCode, string courseName, Teacher instructor)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            CourseInstructor = instructor;
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void DisplayStats()
        {
            Console.WriteLine("\n=== ข้อมูลรายวิชา: {CourseCode} {CourseName} ===");
            Console.WriteLine("อาจารย์ผู้สอน: {CourseInstructor.Name} (สาขา: {CourseInstructor.Department})");
            Console.WriteLine("-");

            if (_students.Count == 0)
            {
                Console.WriteLine("ยังไม่มีนักศึกษาลงทะเบียนในวิชานี้");
                return;
            }

            double max = _students.Max(s => s.Score);
            double min = _students.Min(s => s.Score);
            double avg = _students.Average(s => s.Score);

            Console.WriteLine("คะแนนสูงสุด: {max}");
            Console.WriteLine("คะแนนต่ำสุด: {min}");
            Console.WriteLine("คะแนนเฉลี่ย: {avg:F2}");

            Console.WriteLine("\nรายชื่อนักศึกษาทั้งหมด:");
            foreach (var student in _students)
            {
                student.DisplayInfo();
            }
        }
    }
}