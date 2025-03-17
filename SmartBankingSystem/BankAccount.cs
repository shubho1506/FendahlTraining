using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    abstract class BankAccount : IBankAccount
    {
        public int AccountNumber { get; }
        public string HolderName { get; }
        public decimal Balance { get; protected set; }

        public AccountTypes AccountType { get; set; }

        protected static readonly string logFile = "TransactionLog.txt";

        public BankAccount(int accountNumber, string holderName, decimal initialBalance,AccountTypes type)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = initialBalance;
            AccountType = type;
            LogTransaction("Account Created", initialBalance);
        }
        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public void LogTransaction(string transactionType , decimal amount)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFile, true))
                {
                    writer.WriteLine($"{DateTime.Now} | {AccountNumber} | {transactionType} | {amount} | Balance: {Balance} ");
                    Console.WriteLine("Order placed successfully.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Logging failed: {e.Message}");

            }
        }
    }
}
