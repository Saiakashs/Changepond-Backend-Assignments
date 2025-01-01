using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Subscriber
    {
        public void doWork()
        {
            Publisher pb = new Publisher();

            /*
             
            pb.myevent += delegate (int a, int b)
            {
                int c = a + b;

                Console.WriteLine($"The Sum of {a} and {b} is: {c}");
            };

            */

            pb.myevent += (a, b) => (a + b); //Lambda Expression

            pb.increment();

        }
    }
}
