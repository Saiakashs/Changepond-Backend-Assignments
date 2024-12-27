// See https://aka.ms/new-console-template for more information

using System;

namespace dotnettutorials
{

    class Employee
    {
        public int eid;
        public string ename;

        public Employee()
        {
            this.eid = 2;
            this.ename = "Anush";
        }
        public Employee(int id, string name)
        {
            this.eid = id;
            this.ename = name;
        }
        public Employee(int id)
        {
            this.eid = id;
        }
        public Employee(string name)
        {
            this.ename = name;
        }


    }

    public class Calculator
    {

        public int result;

        public int calculatorSum(int num1,int num2)
        {
            result = num1+num2;
            return result;
        }
    }

    class Program
    {
        int numid;

        private static void Main(string[] args)
        {
            //Console.Write("Akash");
            //Console.WriteLine("Sai Kutthalingam S");

            int id = 1;
            string fname = "Sai Kutthalingam S";
            double height = 5.8;
            bool isMarried = false;

            Console.WriteLine(fname + "id is " + id + " and height is " + height);
            Console.WriteLine("Marital Status:" + isMarried);
            Console.ReadKey();

            int res;
            Calculator calsum = new Calculator();
            res=calsum.calculatorSum(10, 20);
            Console.WriteLine(res);

            Employee e = new Employee();
            e.eid = 1;
            e.ename = "Kamali";
            Console.WriteLine("Id:"+e.eid);
            Console.WriteLine("Name:" + e.ename);

            Employee e1 = new Employee();
            Console.WriteLine("Id:" + e1.eid);
            Console.WriteLine("Name:" + e1.ename);

            Employee e2 = new Employee(3,"Ashwin");
            Console.WriteLine("Id:" + e2.eid);
            Console.WriteLine("Name:" + e2.ename);

            Employee e3 = new Employee(4);
            Console.WriteLine("Id:" + e3.eid);
            Console.WriteLine("Name:" + e3.ename);

            Employee e4 = new Employee("Ashwin");
            Console.WriteLine("Name:" + e4.ename);

        }
    }
}
