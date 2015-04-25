using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Bank
    {
        private static Account account1 = new Account(0001, 12.00);
        private static Account account2 = new Account(0002, 6.00);
        private static Account account3 = new Account(0003, 0.35);
        private static Account accountError = new Account(9999, 0.00);

        public static bool checkAdequateBalance(int accountNumber, double amount) 
        {
            if (amount > queryAccounts(accountNumber).getBalance()){
                return false;
            }
            return true;
        }

        private static Account queryAccounts(int id) 
        {
            switch (id) { 
                case 0001:
                    return account1;
                case 0002:
                    return account2;
                case 0003:
                    return account3;
                default:
                    return accountError;
            }
        }
    }
}
