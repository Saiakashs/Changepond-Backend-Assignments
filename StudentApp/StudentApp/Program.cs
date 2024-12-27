using System.Security.Principal;

namespace StudentApp {
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Student Application Management System");
            Console.ReadKey();

            /*
             
            Student s1=new Student();
            s1.rollno = Student.incrementID();
            s1.sname = "Sai";
            s1.gender = 'M';

            // Console.WriteLine("RollNo:" + s1.rollno + " Name:" + s1.sname + " Gender:" + s1.gender);


            s1.displayDetails(rollno: s1.rollno, sname: s1.sname, gender: s1.gender);

            Student s2 = new Student();
            s2.rollno = Student.incrementID();
            s2.sname = "Arun";
            s2.gender = 'M';

            // Console.WriteLine("RollNo:" + s2.rollno + " Name:" + s2.sname + " Gender:" + s2.gender);

            s2.displayDetails(sname: s2.sname, gender: s2.gender);

            */

            /*
             * 
            Student s1 = new Student();
            s1.rollno = Student.incrementID();
            s1.pname = "Sai";
            s1.gender = 'M';
            s1.showDetails();
            s1.City = "Tirunelveli";
            s1.State = "TamilNadu";
            s1.Zipcode = 627006;
            Console.WriteLine(s1.getAddress());
            s1.mobile = 9360335010;
            s1.email = "saiakash200236@gmail.com";
            Console.WriteLine(s1.showContact());

            */

            /*
             
            Faculty f1 = new Faculty();
            f1.rollno = Student.incrementID();
            f1.pname = "Sai";
            f1.gender = 'M';
            f1.showDetails();
            f1.City = "Tirunelveli";
            f1.State = "TamilNadu";
            f1.Zipcode = 627006;
            Console.WriteLine(f1.getAddress());
            f1.mobile = 9360335010;
            f1.email = "saiakash200236@gmail.com";
            Console.WriteLine(f1.showContact());

            */

            StudentApp.Banking.BankAccount ba;
            ba=new Banking.BankAccount();

           
            Console.WriteLine("Current Balance Before Deposit {0}", ba.currentBalance);
            //Console.Write("Enter the Deposit Amount:");
            //double damount = Convert.ToDouble(Console.ReadLine());

            ba.Deposit(1000);

            Console.WriteLine("After Deposit {0} Current Balance {1}",1000, ba.currentBalance);

           // Console.Write("Enter the Withdraw Amount:");
            //wamount = Convert.ToDouble(Console.ReadLine());

            ba.Withdraw(500);

            Console.WriteLine("Current Balance After Withdraw {0}", ba.currentBalance);

            Console.ReadKey();




        }
    }
}
