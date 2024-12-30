
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayFunction
    {
        public void showArrayFunction()
        {
            int[] numbers = { 10, 200, 6, 4, 51 };

            int[] newNumbers = new int[5];

            Console.WriteLine(Array.IndexOf(numbers,6));

            Console.WriteLine(Array.BinarySearch(numbers, 6));

            numbers.CopyTo(newNumbers,0);

            Array.Resize(ref newNumbers, 7);
            newNumbers[5] = 15;
            newNumbers[6] = 13;

            Array.Clear(newNumbers);

            Array.Sort(numbers);

            Array.Reverse(numbers);

            Console.WriteLine("===============================");

            /*
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            */

            foreach(int num in newNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
