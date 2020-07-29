using System.Linq;
using System.Collections.Generic;
using CoreSchool.Entities;

namespace CoreSchool 
{
    public class SchoolEngine 
    {
        public School School { get; set; }

        public SchoolEngine()
        {
        }

        public void Initialize()
        {
            this.School = new School(
                "Platzi",
                2012,
                SchoolTypes.HighSchool,
                country: "Perú (PEN)",
                city: "Pucallpa (PCL)"
            );

            LoadCourses();
            LoadSubjects();
            LoadStudents();
            LoadEvaluations();
        }

        private void LoadCourses()
        {
            this.School.Courses = new List<Course>() {
                new Course() {
                    Name = "Design Patterns - Platzi",
                    WorkdayType = WorkdayTypes.Morning,
                },
                new Course() {
                    Name = "Domain Drive Design - Platzi",
                    WorkdayType = WorkdayTypes.Afternoon,
                },
                new Course {
                    Name = "SOLID - Platzi",
                    WorkdayType = WorkdayTypes.Night,
                },
                new Course {
                    Name = "POO in C# - Platzi",
                    WorkdayType = WorkdayTypes.Morning,
                },
                new Course {
                    Name = "MVC in PHP - Platzi",
                    WorkdayType = WorkdayTypes.Afternoon,
                },
            };
        }

        private void LoadStudents()
        {
            
        }

        private void LoadSubjects()
        {
            foreach (var course in this.School.Courses)
            {
                course.Subjects.AddRange(new List<Subject>() {
                    new Subject { Name = "Matemática I" },
                    new Subject { Name = "Comunicaión Integral" },
                    new Subject { Name = "Educación Ambiental" },
                    new Subject { Name = "Educación Física" },
                });
            }
        }

        private void LoadEvaluations()
        {
            foreach (var course in this.School.Courses)
            {
                course.Students.AddRange(this.GetRandomStudents());
            }
        }
        private IEnumerable<Student> GetRandomStudents()
        {
            string[] names = {
                "Luis", "Alberto", "Carlos", "Pedro"
            };
            string[] firstSurnames = {
                "Damian", "Saavedra", "Chavez", "Tananta"
            };
            string[] secondSurnames = {
                "Chavez", "Ayala", "Guevara", "Mendieta"
            };

            var students = from name in names
                           from first in firstSurnames
                           from second in secondSurnames
                           select new Student { Name = $"{name} {first} {second}" };

            return students;
        }

        public void PrintCourses()
        {
            School.PrintCourses();
        }
    }
}