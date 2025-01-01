using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Calculator
    {
        
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine($"The Sum of {a} and {b} is: {c}");

        }

        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"The Subtract of {a} and {b} is: {c}");

        }
    }
}
