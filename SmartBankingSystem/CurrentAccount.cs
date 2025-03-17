using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class CurrentAccount : BankAccount
    {
        private static readonly decimal OverdraftLimit = 5000m; 

        public CurrentAccount(int accountNumber, string holderName, decimal initialBalance, AccountTypes type)
            : base(accountNumber, holderName, initialBalance, type) { }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            LogTransaction("Deposit", amount);
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                LogTransaction("Withdrawal", amount);
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {Balance}");
            }
            else
            {
                throw new InsufficientBalanceException();
            }
        }
    }
}
