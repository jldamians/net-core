using System;

namespace core_escuela
{
    class School
    {
        public string name;
        public string address;
        public int foundationYear;

        public void ringTheBell() {
            Console.WriteLine("Call for lunch: {0}", this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School mySchool = new School();
            mySchool.name = "Ricardo Bentin Grande";
            mySchool.address = "Coronel Portillo, Manantay";
            mySchool.foundationYear = 1900;
            mySchool.ringTheBell();
        }
    }
}
