using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    namespace Banking
    {
        partial class BankAccount
        {
            public int accountNo = 1234;
            public string accountName = "John";
            public double currentBalance = 100000;

            public void Deposit(double amount)
            {
                currentBalance += amount;

            }
        }
    }
   
}
