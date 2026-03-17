using System;

namespace CourseGradingSystem
{
    public abstract class Person
    {
        private string _id;
        private string _name;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayInfo();
    }
}