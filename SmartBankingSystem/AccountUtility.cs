using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class AccountUtility
    {
        private static int lastAccountNumber = 1000;

        public static int GenerateAccountNumber()
        {
            return ++lastAccountNumber;
        }

        public static void SaveAccountDetails(BankAccount account)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Accounts.txt", true))
                {
                    writer.WriteLine($"{account.AccountNumber},{account.HolderName},{account.AccountType},{account.Balance}");
                    Console.WriteLine("Order placed successfully.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Logging failed: {e.Message}");

            }
        }

        public static void LoadAccounts(List<BankAccount> accounts)
        {
            if (File.Exists("Accounts.txt"))
            {
                foreach (var line in File.ReadAllLines("Accounts.txt"))
                {
                    string[] parts = line.Split(',');
                    int accNum = int.Parse(parts[0]);
                    string name = parts[1];
                    string type = parts[2];
                    decimal balance = decimal.Parse(parts[3]);
                    if ((Enum.TryParse(type, true, out AccountTypes AType)) && AType.Equals(AccountTypes.Savings))
                    {
                        accounts.Add(new SavingsAccount(accNum, name, balance, AType));
                    }
                    else
                    {
                        accounts.Add(new CurrentAccount(accNum, name, balance, AType));
                    }
                }
            }
        }
    }
}
