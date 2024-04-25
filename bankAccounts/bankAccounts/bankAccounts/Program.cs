using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saveAccount = new SavingsAccount("Fred Wilson", 123456, 432, 0.02F);

            Console.WriteLine("Interest this Month = " + saveAccount.MonthlyInterest);

            CheckingAccount useAccount = new CheckingAccount("Fred Wilson", 123456, 432, 0.02F, 500);

            Console.WriteLine("Interest this Month = " + useAccount.MonthlyInterest);
            Console.WriteLine("Deposit 1498");
            useAccount.DepositMoney(1498);
            Console.WriteLine("Balance = " + useAccount.AccountBalance);
            Console.WriteLine("Draw 800 = " + useAccount.DrawMoney(500));
            Console.ReadKey();
        }
    }
}
