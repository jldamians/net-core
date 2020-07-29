using System;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UUID { get; private set; }
        public string Name { get; private set; }

        public Student(string name)
        {
            UUID = Guid.NewGuid().ToString();
            Name = name;
        }
    }
}