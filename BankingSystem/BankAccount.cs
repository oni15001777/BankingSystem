using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class BankAccount
    {
        private string accNumber;
        private double balance;
        public Branch branch;
        public Customer customer;
        private List<Transaction> activity = new List<Transaction>();
        private string pin;
        
        public BankAccount()
        {

        }

        public BankAccount(string AccNumber, double Balance, Branch Branch, Customer Customer)
        {
            this.accNumber = AccNumber;
            this.balance = Balance;
            this.branch = Branch;
            this.customer = Customer;
            this.pin = "0000";
        }

        public string AccountNo
        {
            get { return accNumber; }
            set { accNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string PIN
        {
            get { return pin; }
            set { 
                if (value.Length == 4)
                {
                    pin = value;
                }
            }
        }

        public double ReturnBalance()
        {
            return balance;
        }

        public double UpdateBalance(Transaction transaction) 
        {
            balance += transaction.Amount;
            activity.Add(transaction);
            return balance;
        }

        public List<Transaction> GetActivity()
        {
            return activity;
        }
    }
}
