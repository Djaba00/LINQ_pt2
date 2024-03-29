﻿using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new []
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents( Classroom[] classes )
        {
            string[] allStudents = (from students in classes
            from student in students.Students
            select student).ToArray();

            return allStudents;
        }
    }
}
