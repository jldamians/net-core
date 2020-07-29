using System;
using System.Collections.Generic;
using static System.Console;
using CoreSchool.Utils;
namespace CoreSchool.Entities
{
    public class School
    {
        public string UUID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course> Courses { get; set; }

        public School(string name, int foundationYear) => (Name, FoundationYear) = (name, foundationYear);

        public School(
            string name, 
            int foundationYear, 
            SchoolTypes schoolType, 
            string country = "", 
            string city = ""
        )
        {
            (Name, FoundationYear) = (name, foundationYear);
            this.Country = country;
            this.City = city;
        }

        public override string ToString()
        {
            return $"School name: \"{this.Name}\" {System.Environment.NewLine}School type: {this.SchoolType} \nCountry: {this.Country} \nCity: {this.City}";
        }

        public void PrintCourses() 
        {
            Printer.PrintTitle("Lista de Cursos");

            if (this.Courses != null)
            {
                foreach (var course in this.Courses)
                {
                    course.printSelf();
                }
            }
            else
            {
                WriteLine("No hay cursos asociados a la escuela");
            }
        }
        public void removeCourseByObject(Course course)
        {
            this.Courses.Remove(course);
        }

        public void RemoveCourseByWorkday(WorkdayTypes workday) 
        {
            this.Courses.RemoveAll((course) => {
                return course.WorkdayType == workday;
            });
        }
    }
}