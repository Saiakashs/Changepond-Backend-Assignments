using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ListMethods
    {
        public void showListMethods()
        {
            List<int> numbers = new List<int>() { 40,10,15,100,74};

            List<int> newNumbers = new List<int>() { 5, 2, 3 };

            numbers.Add(11);

            numbers.Insert(2, 55);

            //numbers.InsertRange(2, newNumbers);

            numbers.AddRange(newNumbers);

            //numbers.Sort();

            //numbers.Reverse();

            //numbers.Remove(40);

            numbers.RemoveAt(5);

            for (int i = 0; i < numbers.Count; i++) { 
                Console.WriteLine(numbers[i]);
            }

           
        }
    }
}
