using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ArrayTask
    {

        public void getData()
        {
            string[] fruits = ["apple", "orange", "banana"];
            bool item1 = false;
            bool item2 = true;
            int index = 0;

            Console.Write("Enter the fruit which you want to replace: ");
            string fruititem1 = Console.ReadLine();
            fruititem1 = fruititem1.ToLower();

            for (int i = 0; i < fruits.Length; i++) {
                if(fruits[i] == fruititem1)
                {
                    item1 = true;
                    index = i;
                }
            }
            if (item1)
            {
                Console.WriteLine($"Yes the fruit {fruititem1} is there");
                Console.Write($"Enter the fruit to replace with {fruititem1}:");
                string fruititem2= Console.ReadLine();
                fruititem2 = fruititem2.ToLower();
                for (int i = 0; i < fruits.Length; i++)
                {
                    if (fruits[i] == fruititem2)
                    {
                        Console.WriteLine($"Sorry the fruit {fruititem2} is already there");
                        item2 = false;
                    }
                }

                if(item2)
                {
                    fruits[index] = fruititem2;
                    foreach (string fruit in fruits)
                    {
                        Console.WriteLine(fruit);
                    }
                }
               

            }
            else
            {
                Console.WriteLine("Soory the fruit you entered is not there");
            }


        }
    }
}
