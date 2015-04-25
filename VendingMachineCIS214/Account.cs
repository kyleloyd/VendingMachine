using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Account
    {
        private int accountNumber;
        private double balance;

        public int getAccountNumber()
        {
            return accountNumber;
        }

        public double getBalance() 
        {
            return balance;
        }

        public Account(int newAccountNumber, double newBalance) 
        {
            accountNumber = newAccountNumber;
            balance = newBalance;
        }
    }
}
