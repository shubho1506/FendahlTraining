using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class CurrentAccount : Account
    {
        private const double OverdraftLimit = 1000; 

        public CurrentAccount(int accountNumber, Customer customer) : base(accountNumber, customer) { }

        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount:F2}. New Balance: ${Balance:F2}");
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount:F2}. New Balance: ${Balance:F2}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
        }
    }
}
