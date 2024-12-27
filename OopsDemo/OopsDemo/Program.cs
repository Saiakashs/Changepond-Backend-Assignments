using System;

namespace OopsDemo{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Company comp = new Company(1, "Changepond");
            //comp.displayCompanyDetails();

            /* Employee emp = new Employee(1, "Changepond");

            emp.eid = 2;
            emp.fname = "Sai Kutthalingam S";
            emp.yob = 2012;
            emp.salary = 100000;

            Console.WriteLine(emp.empDetails()); */

            /* Customer c = new SavingsAccount();
            c.TotalAmount = 10000;
            Console.WriteLine(c.GetTotalAmount());


            Customer c1 = new CurrentAccount();
            c1.TotalAmount = 15000;
            Console.WriteLine(c1.GetTotalAmount());

            SavingsAccount sa = new SavingsAccount();
            sa.TotalAmount = 20000;
            Console.WriteLine(sa.GetTotalAmount());
            Console.WriteLine(sa.branchAddress()); */

            Student s = new Student(1, "Akash");
            Console.WriteLine("ID: " + s.sid + "Name: " + s.sname);
            //Console.WriteLine("College: " + Student.collegename);
            Student.collegename = "FXEC";
            Console.WriteLine("College: " + Student.collegename);
            Console.WriteLine("Semester: " + Student.semester);
            Console.ReadKey();
            

        }
    }
}
