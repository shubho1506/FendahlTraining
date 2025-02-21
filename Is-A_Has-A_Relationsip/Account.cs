using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //6. Problem Statement for Both Relationships in a Banking System
    //Problem:
    //Design a simple banking system with different types of accounts (e.g., SavingsAccount and CurrentAccount).
    //Each account should also have a Customer object that stores the customer’s details like Name, Address, and PhoneNumber
    abstract class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; protected set; }
        public Customer AccountHolder { get; set; } 

        public Account(int accountNumber, Customer customer)
        {
            AccountNumber = accountNumber;
            AccountHolder = customer;
            Balance = 0;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance:F2}");
            AccountHolder.DisplayCustomerInfo();
        }
    }
}
