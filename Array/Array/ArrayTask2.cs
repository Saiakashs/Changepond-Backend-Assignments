using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayTask2:ArrayTask1
    {
        public void displayData4() {

            while (true)
            {
                Console.WriteLine("Operations");
                Console.WriteLine();
                Console.WriteLine("1. Display Fruit");
                Console.WriteLine("2. Find Fruit");
                Console.WriteLine();
                Console.Write("Enter any one option:");
                int number=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (number == 1)
                {
                    displayData2();
                }
                else if (number == 2)
                {
                    displayData3();
                }
                else
                {
                    Console.WriteLine("Please Enter any option correctly!");
                    Console.WriteLine();
                }

            }
        }
    }
}
