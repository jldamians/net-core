using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UUID { get; private set; }
        public string Name { get; set; }
        public WorkdayTypes WorkdayType { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }

        public Course() {
            this.UUID = Guid.NewGuid().ToString();
        }

        public void PrintSelf() {
            string message;
            message = $"[{this.GetHashCode()}][{this.UUID}] {this.Name}";
            Console.WriteLine(message);
        }

        public void SetSubjects(List<Subject> subjects)
        {
            this.Subjects = subjects;
        }
        public void SetStudents(List<Student> students)
        {
            this.Students = students;
        }
    }
}