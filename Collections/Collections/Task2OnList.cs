using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Collections
{
    public class Task2OnList 
    {

        FunctionServices fs = new FunctionServices();
       

        List<Employee> employee = new List<Employee>() { };


        public void Task1()
        {
            while (true)
            {

                fs.displayMessage("Menu");

                fs.displayNoMessage();

                List<string> Menu = new List<string>() { "Display Employee List", "Add Employee", "Update Employee", "Delete Employee", "Exit" };

                for (int i = 0; i < Menu.Count; i++)
                {
                    fs.displayMessage($"{i + 1}. {Menu[i]}");

                }

                fs.displayNoMessage();

                int selectitem = Convert.ToInt32(fs.getInputFromUser("Enter any one option:"));

                if (selectitem == 1){
                    displayData();
                }

                else if (selectitem == 2)
                {
                    addData();
                }

                else if (selectitem == 3)
                {
                    updateData();
                }

                else if (selectitem == 4)
                {
                    deleteData();
                }

                else if (selectitem == 5)
                {
                    exitdata();
                    break;
                }

                else
                {
                    fs.displayMessage("Please enter the option correctly");
                    fs.displayNoMessage();
                }


            }
        }




        public void displayData()
        {
            fs.displayNoMessage();
            fs.displayListObjectItem(employee);
            fs.displayNoMessage();
        }

        public void addData()
        {
            fs.displayNoMessage();

            bool trigger = true;
            int id = employee.Count + 1;
            string name = fs.getInputFromUser("Enter the Employee Name:");
            string empname = fs.TitleCaseString(name);
            string designation = fs.getInputFromUser("Enter the Employee Designation:");
            string empdesignation = fs.TitleCaseString(designation);
            fs.displayNoMessage();


            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].Name.Contains(empname) && employee[i].Designation.Contains(empdesignation))
                {
                  trigger = false;
                }
            }

            if (trigger)
            {
                Employee emp = new Employee(id, empname, empdesignation);

                employee.Add(emp);
            }
        
            else
            {
                Console.WriteLine($"Name: {empname} and Designation: {empdesignation} is already in the list please give unique value");
            }

        }

        public void updateData()
        {
            fs.displayNoMessage();


           
            fs.displayNoMessage();

            string name = fs.getInputFromUser("Enter the name which you want to replace:");
            string empName = fs.TitleCaseString(name);

            bool trigger1 = false;

            bool trigger2 = true;

            int index=-1;

            string empName2;

            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].Name.Equals(empName))
                {
                    trigger1 = true;
                    index = i;
                }
            }


            if (trigger1)
            { 
               
                    string name2 = fs.getInputFromUser($"Enter the name to replace with {empName}:");
                    fs.displayNoMessage();
                    empName2 = fs.TitleCaseString(name2);

                    for (int i = 0; i < employee.Count; i++)
                    {
                        if (employee[i].Name.Equals(empName2))
                        {
                            trigger2 = false;
                        }
                    }

                    if (trigger2)
                    {

                            string designation = employee[index].Designation;  
                            employee.RemoveAt(index);                     
                            Employee newEmp = new Employee(index + 1, empName2, designation);
                            employee.Insert(index, newEmp);
                            fs.displayMessage($"The employee {empName} is replaced with {empName2} successfully");

                    }

                    else
                    {
                        fs.displayMessage($"Sorry the entered Name:{empName2} is already in the list");
                        fs.displayNoMessage();
                    }

            }
              
            

            else
            {
                fs.displayMessage($"Sorry the Name:{empName} which you entered is not in the Employee List.");
                fs.displayMessage("Please Enter the Name which is in the List.");
                fs.displayMessage("If your name not in the list, first add to the List.");
                fs.displayNoMessage();
            }

        }

        public void deleteData()
        {
            string name = fs.getInputFromUser("Enter the name which you want to delete: ");
            string empName=fs.TitleCaseString(name);
            int index2 = -1;

            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i].Name.Equals(empName)){
                    index2 = i;
                }
                else
                {
                    fs.displayMessage($"Sorry the Name:{empName} is not in the list");
                }
                employee.RemoveAt(index2);
                fs.displayMessage($"Name:{name} got successfully deleted in the list");
                fs.displayNoMessage();

            }

        }

        public void exitdata()
        {
            fs.displayMessage("Exited Successfully");
        }
          
        
 }
   }


       


