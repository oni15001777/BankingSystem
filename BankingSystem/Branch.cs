using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Branch
    {

        public string address;
        public string manager;
        public HeadOffice headOffice;

        public Branch()
        {

        }

        public Branch(string Address, string Manager, HeadOffice HeadOffice)
        {
            this.address = Address;
            this.manager = Manager;
            this.headOffice = HeadOffice;
        }

        public string Address
        {
            get { return manager; }
            set { address = value; }
        }
    }
}
