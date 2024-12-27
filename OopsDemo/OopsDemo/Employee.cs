using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Employee : Company
    {

        private int _id;
        private string _fname;
        private int _yob;
        private double _salary;
        private int _age;

        public int eid
        {
            get { return _id; }
            set { _id = value; }
        }

        public string fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public int yob
        {
            set {

                _yob = value;

                _age = 2024 - _yob;

                if (_age < 18)
                {
                    Console.WriteLine("You are not allowed to register");
                    _age = 0;
                }
            }
        }

        public int age
        {
            get { return _age; }

        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        public Employee(int id,string name) : base(id,name) {
            
        }

        public string empDetails()
        {
            base.displayCompanyDetails();
            return "Your Name is: " + _fname + ". Your Age is: " + _age + ". Your Salary is:" + _salary;
        }
    }
}
