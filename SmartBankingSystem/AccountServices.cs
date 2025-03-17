using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class AccountServices
    {
        static List<BankAccount> accounts = new List<BankAccount>();

        internal void CreateAccount()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Select Account Type (1: Savings, 2: Current): ");
            int type = int.Parse(Console.ReadLine());

            int accountNumber = AccountUtility.GenerateAccountNumber();
            BankAccount account;
            if (type == 1)
            {
                account = new SavingsAccount(accountNumber, name, 0, AccountTypes.Savings);
            }
            else
            {
                account = new SavingsAccount(accountNumber, name, 0, AccountTypes.Current);

            }
            accounts.Add(account);
            AccountUtility.SaveAccountDetails(account);
            Console.WriteLine($"Account Created: {accountNumber}");
        }

        internal BankAccount FindAccount(int accountNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accountNumber)
                   ?? throw new InvalidAccountException();
        }

        internal void PerformDeposit()
        {
            Console.Write("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            FindAccount(accNum).Deposit(amount);
        }

        internal void PerformWithdrawal()
        {
            Console.Write("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            try
            {
                FindAccount(accNum).Withdraw(amount);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        internal void ViewAccount()
        {
            Console.Write("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            BankAccount acc = FindAccount(accNum);
            Console.WriteLine($"Account: {acc.AccountNumber}, Name: {acc.HolderName}, Balance: {acc.Balance}");
        }
    }
}
