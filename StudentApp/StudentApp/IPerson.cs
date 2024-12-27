using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface IPerson
    {
        string pname { get; set; }
        char gender { get; set; }

        void showDetails();
    }
}
