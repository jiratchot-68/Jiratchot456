using System;

namespace CourseGradingSystem
{
    public class Teacher : Person
    {
        public string Department { get; set; }

        public Teacher(string id, string name, string department) : base(id, name)
        {
            Department = department;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Teacher ID: {Id} | Name: {Name} | Department: {Department}");
        }
    }
}