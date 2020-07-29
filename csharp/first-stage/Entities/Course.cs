using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UUID { get; private set; }
        public string Name { get; set; }
        public WorkdayTypes WorkdayType { get; set; }

        public Course() {
            this.UUID = Guid.NewGuid().ToString();
        }

        public void printSelf() {
            string message;
            message = $"[{this.GetHashCode()}][{this.UUID}] {this.Name}";
            Console.WriteLine(message);
        }
    }
}