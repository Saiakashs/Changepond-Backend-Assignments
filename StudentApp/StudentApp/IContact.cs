using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface IContact
    {
        public long mobile { get; set; }

        public string email { get; set; }

        public string showContact();
    }
}
