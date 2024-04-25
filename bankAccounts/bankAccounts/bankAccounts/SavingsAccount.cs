
namespace BankAccounts
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string name, int number, double balance, double rate)
        : base(name, number, balance, rate)
        {
        }

        public double EmptyAccount()
        {
            double amount = AccountBalance;
            AccountBalance = 0;
            return amount;
        }
    }
}
