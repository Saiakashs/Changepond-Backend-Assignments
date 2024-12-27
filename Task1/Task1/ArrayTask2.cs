using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ArrayTask2
    {
        public void getData2()
        {
            Console.Write("Enter the words you want:");
            string words = Console.ReadLine();
            string[] nameArray = words.Split(" ");
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < nameArray.Length; i++)
            {
                count1++;
            }
            Console.WriteLine($"The words in the entered string is: {count1}");

            Console.Write("Enter the character you want to search:");

            char[] characters=words.ToCharArray();
            char searchletter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].Equals(searchletter))
                {
                    count2++;
                }
                
            }

            Console.WriteLine($"The character {searchletter} in the words are:{count2}");


        }
    }
}
