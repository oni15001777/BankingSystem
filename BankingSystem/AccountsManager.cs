using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public static class AccountsManager
    {

        public static List<BankAccount> accounts = new List<BankAccount>();

        //add account to static
        public static void RegisterAccount(BankAccount account)
        {
            accounts.Add(account);
        }


        //return requested account
        public static BankAccount GetAccount(string acc)
        {
            foreach (BankAccount account in accounts)
            {
                if(account.AccountNo == acc)
                {
                    return account;
                }

            }

            return null;
        }


    }
}
