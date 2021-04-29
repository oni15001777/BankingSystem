using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public static class Authenticator
    {

        public static bool Authenticate(BankAccount b, string pin)
        {
            if (b.PIN == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
