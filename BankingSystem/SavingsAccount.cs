using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {

        }

        public SavingsAccount(string AccNumber, double Balance, Branch Branch, Customer Customer) : base(AccNumber, Balance, Branch, Customer)
        {

        }

    }
}
