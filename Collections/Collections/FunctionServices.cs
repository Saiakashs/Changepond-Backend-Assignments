using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class FunctionServices
    {
        public void displayMessage(string message)
        {

            Console.WriteLine($"{message}");
        }

        public void displayNoMessage()
        {

            Console.WriteLine("");
        }

        public string getInputFromUser(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }
        public void displayListItem<T>(List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Employee ID:{item}");
               
            }
        }

        /*
        
        public void displayListIntItem(List<int> items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }

        */

        public void displayListObjectItem(List<Employee> items)
        {
            if (items.Count==0){
                Console.WriteLine("Please add any employee list before display it");
            }
            else
            {
                foreach(var item in items)
                {
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Designation);
                }
            }
            
        }

        public string TitleCaseString(string item)
        {
            return item= char.ToUpper(item[0]) + item.Substring(1).ToLower();
        }
        public void TitleCaseArray(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = char.ToUpper(items[i][0]) + items[i].Substring(1).ToLower();
            }
        }

        public void TitleCaseList(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i] = char.ToUpper(items[i][0]) + items[i].Substring(1).ToLower();
            }
        }
       
    }
}
