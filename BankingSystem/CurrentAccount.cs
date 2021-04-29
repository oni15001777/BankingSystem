using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class CurrentAccount : BankAccount
    {

        public CurrentAccount()
        {

        }

        public CurrentAccount(string AccNumber, double Balance, Branch Branch, Customer Customer):base(AccNumber, Balance, Branch, Customer)
        {

        }

    }
}
