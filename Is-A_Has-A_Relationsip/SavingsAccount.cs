using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class SavingsAccount : Account
    {
        private const double InterestRate = 0.03; // 3% Interest

        public SavingsAccount(int accountNumber, Customer customer) : base(accountNumber, customer) { }

        public override void Deposit(double amount)
        {
            Balance += amount + (amount * InterestRate);
            Console.WriteLine($"Deposited ${amount:F2} with interest. New Balance: ${Balance:F2}");
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount:F2}. New Balance: ${Balance:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
