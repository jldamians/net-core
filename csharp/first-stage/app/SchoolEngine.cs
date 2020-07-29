using System.Linq;
using System.Collections.Generic;
using CoreSchool.Entities;
using System;

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
            //LoadEvaluations();
        }

        private void LoadCourses()
        {
            this.School.SetCourses(new List<Course>() {
                this.GetNewRandomCourse(WorkdayTypes.Morning),
                this.GetNewRandomCourse(WorkdayTypes.Afternoon),
                this.GetNewRandomCourse(WorkdayTypes.Morning),
                this.GetNewRandomCourse(WorkdayTypes.Afternoon),
            });
        }

        private Course GetNewRandomCourse(WorkdayTypes workdayType)
        {
            string[] names = {
                "101", 
                "201", 
                "301", 
                "401",
                "501",
                "601",
                "701",
                "801",
                "901",
                "102",
                "202",
                "302",
                "402",
                "502",
            };

            var newCourse = new Course() { 
                Name = names[new Random().Next(names.Length)], 
                WorkdayType = workdayType 
            };

            var subjects = this.GetRandomSubjects();
            var students = this.GetRandomStudents();

            this.AddRandomEvaluations(students, subjects);

            newCourse.SetSubjects(subjects);
            newCourse.SetStudents(students);

            return newCourse;
        }

        private List<Student> GetRandomStudents(int quantity = 5)
        {
            string[] names = {
                "Luis", "Alberto", "Carlos", "Pedro", "Gustavo", "Andres"
            };
            string[] firstSurnames = {
                "Damian", "Saavedra", "Chavez", "Tananta", "Artica", "Caceres"
            };
            string[] secondSurnames = {
                "Chavez", "Ayala", "Guevara", "Mendieta", "Garcia", "Salcedo"
            };

            var students = from name in names
                           from first in firstSurnames
                           from second in secondSurnames
                           select new Student { Name = $"{name} {first} {second}" };
            
            return students
                .OrderBy((student) => student.UUID)
                .Take(quantity)
                .ToList();
        }

        private List<Subject> GetRandomSubjects(int quantity = 5)
        {
            string[] names = {
                "Matemáticas", 
                "Comunicación", 
                "Religión", 
                "Ecología", 
                "Física", 
                "Química",
                "Computación",
                "Electricidad",
                "Cálculo",
                "Trigonometría",
                "Álgebra",
                "Natación",
                "Ofimática",
                "Ciencias Sociales",
            };

            var subjects = from name in names
                           select new Subject { Name = name };
            
            return subjects
                .OrderBy((student) => student.UUID)
                .Take(quantity)
                .ToList();
        }

        private List<Student> AddRandomEvaluations(List<Student> students, List<Subject> subjects)
        {
            foreach (var student in students)
            {
                foreach (var subject in subjects)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        student.Evaluations.Add(new Evaluation() {
                            Subject = subject,
                            Name = $"{subject.Name} [#{i + 1}]",
                            Score = (float)(5 * new Random().NextDouble()),
                            Student = student,
                        });
                    }                    
                }
            }

            return students;
        }

        public void PrintCourses()
        {
            School.PrintCourses();
        }
    }
}