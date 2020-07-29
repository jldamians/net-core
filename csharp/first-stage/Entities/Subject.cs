using System;

namespace CoreSchool.Entities
{
    public class Subject
    {
        public string UUID { get; private set; }
        public string Name { get; set; }

        public Subject()
        {
            UUID = Guid.NewGuid().ToString();
        }
    }
}