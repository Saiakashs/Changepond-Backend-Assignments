﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    namespace Banking
    {
        partial class BankAccount
        {
            public void Withdraw(double amount)
            {
                currentBalance -= amount;
            }
        }
    }

}
