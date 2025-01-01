using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Employee
    {

        private int EmployeeID;
        private string EmployeeName;
        private string EmployeeDesignation;

        public int ID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        public string Name
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }

        public string Designation
        {
            get { return EmployeeDesignation; }
            set { EmployeeDesignation = value; }
        }
        public Employee(int id,string name,string designation)
        {
            this.EmployeeID = id;
            this.EmployeeName = name;
            this.EmployeeDesignation = designation;
        }
    }
}
