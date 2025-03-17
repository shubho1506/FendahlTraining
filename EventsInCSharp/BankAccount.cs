using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    //    Problem 3: Event Notification System
    //Develop a simple notification system for a bank account where an event is triggered when a withdrawal exceeds the balance.
    //•	Define a delegate BalanceExceededHandler and an event OnBalanceExceeded.
    //•	Implement a BankAccount class with properties Balance and a method Withdraw(int amount).
    //•	Raise the event if the withdrawal amount exceeds the balance.
    //•	Subscribe to the event and display a message indicating insufficient funds.

    class BankAccount
    {
        public delegate void BalanceExceededHandler(string message);

        public event BalanceExceededHandler OnBalanceExceeded;

        public int Balance { get; private set; }

        public BankAccount(int initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                OnBalanceExceeded?.Invoke($"Insufficient funds! Available Balance: {Balance}, Withdrawal Attempt: {amount}");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful! New Balance: {Balance}");
            }
        }
    }
}
