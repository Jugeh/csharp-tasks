using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class CheckingAccount : BankAccount
    {
        private double nostoraja;

        public CheckingAccount(string name, int number, double balance, double rate, double nostoraja)
        : base(name, number, balance, rate)
        {
            this.nostoraja = nostoraja;
        }

        public double DrawMoney(double kertanosto)
        {
            if (kertanosto > nostoraja)
            {
                Console.WriteLine("You are not allowed to withdraw more money than your withdrawal limit is");
                Console.ReadKey();
                return 0.00D;
            }
            else if (kertanosto > AccountBalance)
            {
                Console.WriteLine("You are not allowed to withdraw more money than your account has");
                Console.ReadKey();
                return 0.00D;
            }
            else
            {
                return kertanosto;
            }
        }

        public void DepositMoney(int talletus)
        {
            accountBalance += talletus;
        }
    }
}
