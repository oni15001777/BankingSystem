using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class HeadOffice
    {

        private string bankName;
        private string address;

        public HeadOffice()
        {

        }

        public HeadOffice(string BankName, string Address)
        {
            this.bankName = BankName;
            this.address = Address;
        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
