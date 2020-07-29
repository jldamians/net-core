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
    
        public void PrintCourses()
        {
            School.PrintCourses();
        }
    }
}