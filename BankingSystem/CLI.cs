using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public static class CLI
    {
        //command line interface

        public static void Login()
        {
            Console.WriteLine("Enter an account number: ");
            string acc = Console.ReadLine();
            Console.WriteLine("Enter PIN: ");
            string pin = Console.ReadLine();

            BankAccount account = AccountsManager.GetAccount(acc);


            if (account != null && Authenticator.Authenticate(account, pin))
            {
                Console.WriteLine("Account Owner Verified - PIN ok!");
                BankingOptions(account);
            }
            else
            {
                Console.WriteLine("Invalid Credentials!");
            }
        }


        //banking options
        public static void BankingOptions(BankAccount account)
        {
            bool menu = true;
            while (menu)
            {

                Console.WriteLine("\n###################################################\n");
                Console.WriteLine("Please select form the following options: ");
                Console.WriteLine("\n1 - Balance\n2 - Withdraw\n3 - Deposit\n4 - Change PIN\n5 - View Transaction\n6 - Exit\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //make call to balance
                        break;
                    case "2":
                        //make call to withdraw
                        Withdraw(account);
                        break;
                    case "3":
                        //make call to deposit
                        break;
                    case "4":
                        //make call to change pin
                        break;
                    case "5":
                        //make call to view transaction
                        Transactions(account);
                        break;
                    case "6":
                        //make call to exit
                        menu = false;
                        Console.WriteLine("Account logged off!");
                        Console.WriteLine("\n###################################################\n");
                        break;
                    default:
                        Console.WriteLine("Input not recognised - please try again");
                        break;
                }
            }
        }

        public static void Withdraw(BankAccount account)
        {
            Console.WriteLine("Enter amount to withdraw: (£)\n");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.UpdateBalance(new Transaction(-amount, "Cash Withdraw"));
        }

        public static void Transactions(BankAccount account)
        {
            List<Transaction> activity = account.GetActivity();
            foreach (Transaction action in activity)
            {
                Console.WriteLine($"Date: {action.TransactionDate}\nAmount: {action.Amount}\nDetails: {action.Info}");
            }
        }

    }
}
