using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public class Person
    {
       /*string[] InputArray = new string[3];

         public void GetInputArray()
         {
             for(int i = 0; i < 3; i++)
             {
                 InputArray[i] = Console.ReadLine(); 
             }

             for (int i = 0; i < InputArray.Length; i++)
             {
                 Console.WriteLine(InputArray[i]);
             }
         } */

        public string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Inheritance";
        }
    }

    public class Student : Person
    {
        public Student(string name): base(name)
        {

        }

        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }

        public void Explain()
        {
            Console.WriteLine("Teacher is explaining");
        }
    }
}
