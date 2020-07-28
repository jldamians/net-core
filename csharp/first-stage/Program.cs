using System.Collections.Generic;
using CoreSchool.Entities;
namespace first_stage
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new School(
                "Ricardo Bentín Grande", 
                1980, 
                SchoolTypes.PrimarySchool,
                city: "Pucallpa",
                country: "Perú"
            );

            /*WriteLine("La escuela {0} fue creada el año {1}", mySchool.Name, mySchool.FoundationYear);
            WriteLine(mySchool.ToString());*/

            mySchool.Courses = new List<Course>() {
                new Course() {
                    Name = "Patrones de Diseño de Software - Platzi",
                    WorkdayType = WorkdayTypes.Afternoon,
                },
                new Course() {
                    Name = "Arquitectura de Software - Platzi",
                    WorkdayType = WorkdayTypes.Afternoon,
                },
                new Course {
                    Name = "Principios SOLID - Platzi",
                    WorkdayType = WorkdayTypes.Morning,
                },
                new Course {
                    Name = "NodeJS + Puppeteer - Platzi",
                    WorkdayType = WorkdayTypes.Morning,
                }
            };

            mySchool.printCourses();
        }
    }
}
