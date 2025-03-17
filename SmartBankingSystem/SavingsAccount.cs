using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class SavingsAccount : BankAccount
    {
        private static readonly decimal InterestRate = 0.03m; 

        public SavingsAccount(int accountNumber, string holderName, decimal initialBalance,AccountTypes type)
            : base(accountNumber, holderName, initialBalance,type) { }

        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate;
            Deposit(interest);
            Console.WriteLine($"Interest Applied: {interest}");
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            LogTransaction("Deposit", amount);
            Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
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
