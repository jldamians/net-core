using System;

namespace CoreSchool.Entities
{
    public class Subject
    {
        public string UUID { get; private set; }
        public string Name { get; private set; }

        public Subject(string name)
        {
            UUID = Guid.NewGuid().ToString();
            Name = name;
        }
    }
}