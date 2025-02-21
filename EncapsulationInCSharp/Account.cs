using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationInCSharp
{
    //Problem 1: Bank Account Management
    //Create a BankAccount class that encapsulates account details such as accountNumber, accountHolderName, and balance.
    //•	Requirements:
    //o The balance field should only be accessible through methods.
    //o Provide methods for depositing and withdrawing money.
    //o Ensure that withdrawals are not allowed if the balance is insufficient.
    //o Add a method to display the account holder’s name and current balance.
    //Encapsulation should ensure that no direct modification of balance is possible without using the provided methods.

    internal class Account : IAccountBluePrint
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        private decimal balance;  

        public Account(int accNumber, string accHolderName, decimal initialBalance = 0)
        {
            AccountNumber = accNumber;
            AccountHolderName = accHolderName;
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"₹{amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"₹{amount} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount!");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\nAccount Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Current Balance: rs {balance}\n");
        }
    }
}
