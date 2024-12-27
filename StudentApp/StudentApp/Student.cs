using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentApp
{
    class Student:IPerson,IAddress,IContact
    {
        // public int rollno { get; set; }

        // public string sname { get; set; }

        //public char gender { get; set; }

        /* public void displayDetails(int rollno=0,string sname="",char gender=' ')
       {
           if (rollno > 0) {
               Console.WriteLine("Roll No: " + rollno);
           }
           if (sname != "")
           {
               Console.WriteLine("Name of Student: " + sname);
           }
           if(gender != ' ')
           {
               Console.WriteLine("Gender: " + gender);
           }
       } */

        public int rollno { get; set; }
        public string pname { get; set ; }
        public char gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zipcode { get; set; }
        public long mobile { get; set; }
        public string email { get; set; }

        public void showDetails()
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No: " + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of Student: " + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender: " + gender);
            }
        }

        public static int id = 0;

        public static int incrementID()
        {
            return ++id;
        }

        public string getAddress()
        {
            return $"City is: {City}, State is: {State}, ZipCode: {Zipcode}";
        }

        public string showContact()
        {
            return $"Phone Number is: {mobile}, Email is: {email}";
        }
    }
}
