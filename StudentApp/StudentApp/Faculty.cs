using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Faculty : IPerson, IAddress, IContact
    {
        public int rollno { get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zipcode { get; set; }
        public long mobile { get; set; }
        public string email { get; set; }


        public static int id = 0;

        public static int incrementID()
        {
            return ++id;
        }

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

        public string getAddress()
        {
            return $"City is: {City}, State is: {State}, Zipcode is: {Zipcode}";
        }

        public string showContact()
        {
            return $"Phone Number is: {mobile}, Email is: {email}";
        }

    }
}
