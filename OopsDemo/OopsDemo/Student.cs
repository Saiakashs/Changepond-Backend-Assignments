using System;

namespace OopsDemo
{
    class Student
    {
        public int sid;
        public string sname;

        public static string collegename="IIT Chennai";

        public const int semester = 8;

        public Student(int id,string name)
        {
            this.sid = id;
            this.sname = name;  
        }
    }

}

