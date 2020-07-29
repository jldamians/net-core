using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student
    {
        public string UUID { get; private set; }
        public string Name { get; set; }
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();

        public Student()
        {
            UUID = Guid.NewGuid().ToString();
        }

        public void SetEvaluations(List<Evaluation> evaluations)
        {
            this.Evaluations = evaluations;
        }
    }
}