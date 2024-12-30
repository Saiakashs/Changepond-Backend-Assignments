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
    public class TaskOnList
    {
        List<string> fruits = new List<string>() { "Apple", "Banana", "orange" };

        FunctionServices fs = new FunctionServices();
        public void Task1()
        {
            fs.TitleCaseList(fruits);
            /*
             
            for (int i = 0; i < fruits.Count; i++)
            {
                fruits[i] = fruits[i].ToLower();
            }

            */

            while (true)
            {
                fs.displayMessage("Menu");
                //Console.WriteLine("Menu");

                fs.displayNoMessage();
                // Console.WriteLine();

                List<string> Menu =new List<string>() { "Display Fruit", "Add Fruit", "Update Fruit", "Delete Fruit", "Exit" };

                for(int i = 0; i < Menu.Count; i++)
                {
                    fs.displayMessage($"{i + 1}. {Menu[i]}");
                    //Console.WriteLine($"{i + 1}. {Menu[i]}");
                }

                /*
                 
                Console.WriteLine("1. Display Fruit");
                Console.WriteLine("2. Add Fruit");
                Console.WriteLine("3. Update Fruit");
                Console.WriteLine("4. Delete Fruit");

                */

                fs.displayNoMessage();
                //Console.WriteLine();


                int selectitem=Convert.ToInt32(fs.getInputFromUser("Enter any one option:"));
                /*
                
                Console.Write("Enter any one option:");
                int selectitem = Convert.ToInt32(Console.ReadLine());

                */

                if (selectitem == 1)
                {
                    displayFruit();
                }

                else if (selectitem == 2)
                {
                    addFruit();
                }

                else if(selectitem == 3)
                {
                    updateFruit();
                }

                else if(selectitem == 4)
                {
                    deleteFruit();
                }

                else if(selectitem == 5)
                {
                    exit();
                    break;
                }

                else
                {
                    fs.displayNoMessage();
                    //Console.WriteLine();

                    fs.displayMessage("Please enter the option correctly");
                    //Console.WriteLine("Please enter the option correctly");
                }
            }
            

        }

        public void displayFruit()
        {
            fs.displayNoMessage();
            //Console.WriteLine();

            fs.displayListItem(fruits);

            /*
             
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            */

            fs.displayNoMessage();
            //Console.WriteLine();
        }

        public void addFruit()
        {

            string item1 = fs.getInputFromUser("Enter the fruit which you want to add: ");
            /*
            Console.Write("Enter the fruit which you want to add: ");
            string fruititem1 = Console.ReadLine();

            */

            //fruititem1 = char.ToUpper(fruititem1[0]) + fruititem1.Substring(1).ToLower();
             
            string fruititem1=fs.TitleCaseString(item1);
            //fruititem1 = fruititem1.ToLower();

            fs.displayNoMessage();
            //Console.WriteLine();

            if (fruits.Contains(fruititem1))
            {
                fs.displayMessage($"Sorry the fruit {fruititem1} which you entered is already in the list");
                //Console.WriteLine($"Sorry the fruit {fruititem1} which you entered is already in the list");

                fs.displayNoMessage();
                //Console.WriteLine();
            }
            else
            {
                fruits.Add(fruititem1);

                fs.displayMessage($"Successfully added the fruit {fruititem1} to the list");
                // Console.WriteLine($"Successfully added the fruit {fruititem1} to the list");

                fs.displayNoMessage();
                //Console.WriteLine();
            }
        }
        public void updateFruit()
        {
            fs.displayNoMessage();
            //Console.WriteLine();

            string item1 = fs.getInputFromUser("Enter the fruit which you want to update: ");
            /*
            
            Console.Write("Enter the fruit which you want to update: ");
            string fruititem1 = Console.ReadLine();

            */

            string fruititem1 = fs.TitleCaseString(item1);
            //fruititem1 = fruititem1.ToLower();


            fs.displayNoMessage();
            //Console.WriteLine();

            if (fruits.Contains(fruititem1))
            {
                int index = fruits.IndexOf(fruititem1);

                fs.displayMessage($"Yes the fruit {fruititem1} is there");
                //Console.WriteLine($"Yes the fruit {fruititem1} is there");

                fs.displayNoMessage();
                //Console.WriteLine();

                string item2 = fs.getInputFromUser($"Enter the fruit to replace with {fruititem1}:");
                /*
                
                Console.Write($"Enter the fruit to replace with {fruititem1}:");
                string fruititem2 = Console.ReadLine();
                
                */

                string fruititem2=fs.TitleCaseString(item2);
                //fruititem2 = fruititem2.ToLower();

                fs.displayNoMessage();
                //Console.WriteLine();

                if (fruits.Contains(fruititem2))
                    {
                        fs.displayMessage($"Sorry the fruit {fruititem2} is already there");
                        //Console.WriteLine($"Sorry the fruit {fruititem2} is already there");

                        fs.displayNoMessage();
                        //Console.WriteLine();
                }

                    else
                    {
                        fruits.Remove(fruititem1);
                        fruits.Insert(index, fruititem2);
                        fs.displayMessage($"The fruit {fruititem1} is replaced with {fruititem2} successfully");
                        //Console.WriteLine($"The fruit {fruititem1} is replaced with {fruititem2} successfully");
                    }
                
            }
            else
            {
                fs.displayMessage($"Sorry the entered fruit {fruititem1} is not in the list");
                //Console.WriteLine($"Sorry the entered fruit {fruititem1} is not in the list");

                fs.displayNoMessage();
                //Console.WriteLine();
            }
        }

        public void deleteFruit()
        {

            string item1=fs.getInputFromUser("Enter the fruit which you want to delete: ");

            /*
            
            Console.Write("Enter the fruit which you want to delete: ");
            string fruititem1 = Console.ReadLine();

            */

            string fruititem1=fs.TitleCaseString(item1);
            //fruititem1 = fruititem1.ToLower();

            fs.displayNoMessage();
            //Console.WriteLine();

            int index = fruits.IndexOf(fruititem1);

            if (fruits.Contains(fruititem1))
            {
                fruits.RemoveAt(index);

                fs.displayMessage($"The fruit {fruititem1} which you entered is successfully deleted from the list");
                //Console.WriteLine($"The fruit {fruititem1} which you entered is successfully deleted from the list");

                fs.displayNoMessage();
                //Console.WriteLine();

            }

            else
            {
                fs.displayMessage($"Sorry the fruit {fruititem1} which you entered is not there in the list");
                //Console.WriteLine($"Sorry the fruit {fruititem1} which you entered is not there in the list");

                fs.displayNoMessage();
                //Console.WriteLine();
            }
        }

        public void exit()
        {
            fs.displayNoMessage();
            fs.displayMessage("Successfully exited");
            
            //Console.WriteLine("Successfully exited");
        }
        
    }
}
