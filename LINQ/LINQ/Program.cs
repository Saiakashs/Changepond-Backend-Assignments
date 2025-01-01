using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
namespace LINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Marks { get; set; }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            /*
             
            //create list collection

            List<int> a = new List<int> { 50, 27, 105, 34, 55, 80, 100, 133 };
            //create an empty new collection

            List<int> b = new List<int>();

            //read all the elements from "a" collection, check the condition, and 
            //add the matching elements into a new collection called "b" using LINQ
            //(Language Integrated Query)

            b = (from item in a where (item % 2 == 0) select item).ToList();
            //get values from the new collection
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }

            */


            //create a collection of "Student" type and initialize 4 objects

            List<Student> Students = new List<Student>()
             {
             new Student() { StudentID = 1, StudentName = "scott", Marks = 40 },
             new Student() { StudentID = 2, StudentName = "allen", Marks = 25 },
             new Student() { StudentID = 3, StudentName = "jones", Marks = 70 },
             new Student() { StudentID = 4, StudentName = "john", Marks = 32 }
             };

            //create a new empty collection

            List<Student> PassedStudents = new List<Student>();

            //read all the objects from "Students" collection, check the condition, 
            //and add matching objects into a new collection using LINQ

            //PassedStudents = (from s in Students where s.Marks >= 35 select 
            //s).ToList();
            PassedStudents = Students.Where(s => s.Marks >= 35).ToList();
            //get objects from "PasssedStudents" collection
            for (int i = 0; i < PassedStudents.Count; i++)
            {
                Student s;
                s = PassedStudents[i];
                Console.Write(s.StudentID);
                Console.Write(", ");
                Console.Write(s.StudentName);
                Console.Write(", ");
                Console.WriteLine(s.Marks);
            }

            Console.ReadKey();
        }
    }
}
