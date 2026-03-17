using System;

namespace Jiratchot
{
    public class Student : Person
    {
        private double _score;

        public double Score
        {
            get => _score;
            set
            {
                if (value >= 0 && value <= 100)
                    _score = value;
                else
                    throw new ArgumentException("Score must be between 0 - 100.");
            }
        }

        public Student(string id, string name, double score) : base(id, name)
        {
            Score = score;
        }

        public string GetGrade()
        {
            if (_score >= 80) return "A";
            if (_score >= 75) return "B+";
            if (_score >= 70) return "B";
            if (_score >= 65) return "C+";
            if (_score >= 60) return "C";
            if (_score >= 55) return "D+";
            if (_score >= 50) return "D";
            return "F";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Student ID: {Id} | Name: {Name} | Score: {Score} | Grade: {GetGrade()}");
        }
    }
}