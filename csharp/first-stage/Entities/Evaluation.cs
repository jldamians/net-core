using System;

namespace CoreSchool.Entities
{
    public class Evaluation
    {
        public string UUID { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Score { get; set; }

        public Evaluation()
        {
            UUID = Guid.NewGuid().ToString();
        }

    }
}