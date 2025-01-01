using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     class Publisher
    {
        public event mydeletegatetype myevent;

        public int x=0, y=0;

        public int z = 0;

        public void increment()
        {
            x += 5;
            y+= 5;

            //myevent(x, y);

            int result = myevent(x, y);
            Console.WriteLine($"The Sum of {x} and {y} is: {result}");
        }

    }
}
