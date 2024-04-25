using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccount
    {

        public string accountName;
        public double accountBalance;
        public int accountNumber;
        public double interestRate;

        public BankAccount(string name, int number, double balance, double rate)
        {
            accountName = name;
            accountBalance = balance;
            accountNumber = number;
            interestRate = rate;
        }

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }

        public double MonthlyInterest
        {
            get
            {
                return interestRate * AccountBalance;
            }
        }

    }
}
