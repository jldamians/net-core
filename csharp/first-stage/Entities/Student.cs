using System;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UUID { get; private set; }
        public string Name { get; set; }

        public Student()
        {
            UUID = Guid.NewGuid().ToString();
        }
    }
}