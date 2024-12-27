using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface IAddress
    {
        public string City { get; set; }

        public string State { get; set; }  

        public long Zipcode { get; set; }

        public string getAddress();
    }
}
