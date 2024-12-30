using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    public class ArrayTask1
    {
        string[] fruits = ["Apple", "Orange", "Banana"];
        public void displayData()
        {
            int[] numbers = [10,20,30,40,50];
          
            //bool item = false;

            Console.Write("Enter the number you want to search:");


            int number = Convert.ToInt32(Console.ReadLine());


            int index = Array.IndexOf(numbers, number);

            /*
             
            foreach (int i in numbers)
            {
                if (i == number)
                {
                    item= true;
                }
            }

            */

            if (index >= 0)
            {
                Console.WriteLine($"Hey the entered number {number} is there in the array");
            }
            else
            {
                Console.WriteLine($"Hey the entered number {number} is not there in the array");
            }
        }

        public void displayData2()
        {
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }

        public void displayData3()
        {
            

            //bool item = false;

            Console.Write("Enter the fruit you want to search:");

            string fruit = Console.ReadLine();

            Console.WriteLine();

            string item = fruit;

            if (fruit != "")
            {
                fruit = char.ToUpper(fruit[0]) + fruit.Substring(1).ToLower();
            }


            else
            {
                Console.WriteLine("Enter any fruit");
            }
           
            

            int index = Array.IndexOf(fruits, fruit);

            /*
             
            foreach (string f in fruits) {
                if (f.Equals(fruits))
                {
                    item = true;
                }
            }
            */

            if (index>=0)
            {
                Console.WriteLine($"Hey the entered fruit {item} is there in the array");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Hey the entered fruit {item} is not there in the array");
                Console.WriteLine();
            }

        }
    }
}
