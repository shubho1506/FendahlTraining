using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInCSharp
{
    class Program
    {
        static List<Account> accounts = new List<Account>();
        static void Main(string[] args)
        {
            EmployeeManagement();
            //BankManagement();
        }

        static void EmployeeManagement()
        {
            Employee emp1 = new Employee("Shubhodeep Sarkar", 101, 50000, "Intern");
            Console.WriteLine(emp1.DisplayDetails()); ;
            emp1.updateSalaryEmp(80000);
            Console.WriteLine(emp1.DisplayDetails()); ;
        }

        static void BankManagement()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bank Account Management ---");
                Console.WriteLine("Press 1 to Create Account");
                Console.WriteLine("Press 2 to Deposit Money");
                Console.WriteLine("Press 3 to Withdraw Money");
                Console.WriteLine("Press 4 to Display Account Details");
                Console.Write("Please enter your choice: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        PerformTransaction("deposit");
                        break;
                    case 3:
                        PerformTransaction("withdraw");
                        break;
                    case 4:
                        DisplayAccount();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1-4.");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using Bank Account Management!");
                    break;
                }
            }
        }

        static void CreateAccount()
        {
            Console.Write("\nPlease enter Account Number: ");
            int accNumber;
            if (!int.TryParse(Console.ReadLine(), out accNumber))
            {
                Console.WriteLine("Invalid account number format!");
                return;
            }

            Console.Write("Please enter Account Holder Name: ");
            string accHolderName = Console.ReadLine();

            Console.Write("Please enter Initial Balance: ");
            decimal initialBalance;
            if (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
            {
                Console.WriteLine("Invalid balance amount!");
                return;
            }

            accounts.Add(new Account(accNumber, accHolderName, initialBalance));
            Console.WriteLine("Account has been created successfully!");
        }

        static void PerformTransaction(string type)
        {
            Console.Write("\nPlease enter Account Number: ");
            int accNumber;
            if (!int.TryParse(Console.ReadLine(), out accNumber))
            {
                Console.WriteLine("Invalid account number format!");
                return;
            }

            Account account = accounts.Find(acc => acc.AccountNumber == accNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write($"Please enter amount to {type}: ");
            decimal amount;
            if (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount!");
                return;
            }

            if (type == "deposit")
                account.Deposit(amount);
            else
                account.Withdraw(amount);
        }

        static void DisplayAccount()
        {
            Console.Write("\nPlease enter Account Number: ");
            int accNumber;
            if (!int.TryParse(Console.ReadLine(), out accNumber))
            {
                Console.WriteLine("Invalid account number format!");
                return;
            }

            Account account = accounts.Find(acc => acc.AccountNumber == accNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            account.DisplayDetails();
        }
    }
}
