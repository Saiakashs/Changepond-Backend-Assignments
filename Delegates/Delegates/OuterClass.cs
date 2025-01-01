using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class OuterClass
    {
        
        public class InnerClass
        {
            public int counter = 1;

            public void doIncrement()
            {
                counter+=5;

                Console.WriteLine($"The value of count is: {counter}");
            }
        }
    }
}
