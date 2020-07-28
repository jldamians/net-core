using System;
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

            /*Console.WriteLine("La escuela {0} fue creada el año {1}", mySchool.Name, mySchool.FoundationYear);
            Console.WriteLine(mySchool.ToString());*/

            var myCourses = new Course[3];

            myCourses[0] = new Course() {
                Name = "Patrones de Diseño de Software - Platzi",
                WorkdayType = WorkdayTypes.Afternoon,
            };

            myCourses[1] = new Course() {
                Name = "Arquitectura de Software - Platzi",
                WorkdayType = WorkdayTypes.Afternoon,
            };

            myCourses[2] = new Course() {
                Name = "Principios SOLID - Platzi",
                WorkdayType = WorkdayTypes.Morning,
            };
            
            printCoursesWithWhileLoop(myCourses);
            printCoursesWithDoWhileLoop(myCourses);
            printCoursesWithForLoop(myCourses);
            printCoursesWithForEachLoop(myCourses);
        }

        private static void printCoursesWithForEachLoop(Course[] myCourses)
        {
            Console.WriteLine("Lista de Cursos (for each loop)");
            Console.WriteLine("===============================");

            foreach (var course in myCourses)
            {
                course.printSelf();
            }
        }

        private static void printCoursesWithForLoop(Course[] myCourses)
        {
            Console.WriteLine("Lista de Cursos (for loop)");
            Console.WriteLine("==========================");

            for (int i = 0; i < myCourses.Length; i++)
            {
                myCourses[i].printSelf();
            }
        }

        private static void printCoursesWithDoWhileLoop(Course[] myCourses)
        {
            int count = 0;

            Console.WriteLine("Lista de Cursos (do while loop)");
            Console.WriteLine("===============================");

            do
            {
                myCourses[count].printSelf();
                count += 1;
            } while (count < myCourses.Length);
        }

        private static void printCoursesWithWhileLoop(Course[] myCourses)
        {
            int count = 0;

            Console.WriteLine("Lista de Cursos (while loop)");
            Console.WriteLine("============================");

            while (count < myCourses.Length)
            {
                myCourses[count].printSelf();
                count += 1;
            }
        }
    }
}
