using System;
using System.Collections.Generic;

namespace BankingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            //initialise dataset
            Initialise.Init();

            //initialise main menu
            while (true)
            {
                CLI.Login();
            }


        }
    }
}
