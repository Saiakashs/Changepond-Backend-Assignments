using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class MathMethods
    {

        public void MathMethod()
        {
            Console.Write("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number as negative number:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} and {num2} = Min: {Math.Min(num1, num2)}");

            Console.WriteLine($"{num1} and {num2} = Max : {Math.Max(num1, num2)}");

            Console.WriteLine($"{num3} = Floor: {Math.Floor(num3)}");

            Console.WriteLine($"{num3} = Ceil: {Math.Ceiling(num3)}");

            Console.WriteLine($"{num1} and {num2} = Power: {Math.Pow(num1, num2)}");

            Console.WriteLine($"{num1} = Square Root: {Math.Sqrt(num1)}");

            Console.WriteLine($"{num4} = Abs: {Math.Abs(num4)}");

            Console.WriteLine($"{num3} = Round: {Math.Round(num3)}");

            int[] number = [6, 10, 1, 4, 7];

            /*
             
            int minimumvalue = number[0];

            for(int i=0;i<number.Length; i++)
            {
                if (number[i] < minimumvalue ) minimumvalue = number[i];
                
                for(int j = i+1; j < number.Length; j++)
                {
                    if (number[j] < minimumvalue )
                    {
                        minimumvalue=number[j];
                    }

                }
            }

            Console.WriteLine(minimumvalue);

            */



            int min = int.MaxValue;

            int max = int.MinValue;
            
            foreach(int n in number)
            {
                if (n<min)
                {
                    min = n;
                }
                if (n>max)
                {
                    max = n;
                }
            }

            Console.WriteLine($"Minimum Value:{min}");

            Console.WriteLine($"Maximum Value:{max}");


           
        }
    }
}
