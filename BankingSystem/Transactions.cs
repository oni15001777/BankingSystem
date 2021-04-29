using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Transaction
    {
        private double amount;
        private DateTime transactionDate;
        private string info;


        public Transaction()
        {

        }

        public Transaction(double Amount, string Info)
        {
            this.Amount = Amount;
            this.transactionDate = DateTime.Now;
            this.Info = Info;
        }

        public double Amount 
        { 
            get => amount; 
            set => amount = value; 
        }
        public DateTime TransactionDate 
        { 
            get => transactionDate; 
        }
        public string Info 
        { 
            get => info; 
            set => info = value; 
        }
    }
}
