﻿using CoreSchool;
namespace first_stage
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.Initialize();
            engine.PrintCourses();
        }
    }
}
