using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Customer
    {
        private string name;
        private string address;

        public Customer()
        {

        }

        public Customer(string Name)
        {
            this.name = Name;
        }

        public Customer(string Name, string Address)
        {
            this.name = Name;
            this.address = Address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
