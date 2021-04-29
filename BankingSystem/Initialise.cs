using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public static class Initialise
    {
        public static void Init()
        {


            HeadOffice HO = new HeadOffice("Natwest Plc.", "London");

            Branch Taunton = new Branch("Fore Street, Taunton", "Mr Matravers", HO);
            Branch Exeter = new Branch("Main Street, Exeter", "Mrs Bicycle", HO);

            Customer jshaun = new Customer("Jim");
            Customer coniche = new Customer("Cristian");
            Customer awilcox = new Customer("Aaron");

            AccountsManager.RegisterAccount(new CurrentAccount("214124412", -164.00, Exeter, coniche));
            AccountsManager.RegisterAccount(new CurrentAccount("333131333", 12.54, Taunton, jshaun));
            AccountsManager.RegisterAccount(new CurrentAccount("441414414", 3000.00, Taunton, awilcox));

            //test current account
            //CurrentAccount acc01 = new CurrentAccount("111223441", 1000.00, Taunton, jshaun);


            //acc01.UpdateBanalce(new Transaction(-100, "Cashpoint withdraw"));
            //acc01.UpdateBanalce(new Transaction(-40, "POS - Game ltd."));


            //add an account to manager
            //AccountsManager.RegisterAccount(acc01);


            //alternative way to add accounts
            AccountsManager.RegisterAccount(new CurrentAccount("0000001", 50000.00, Taunton, coniche));


            //add saver account
            AccountsManager.RegisterAccount(new SavingsAccount("0000002", 50000.00, Taunton, jshaun));

        }



    }
}
