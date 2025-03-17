using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    //Q.1Develop a Smart Banking System for account creation, management, and transactions. 
    //1. Support multiple account types, transaction notifications, and secure data handling.
    //2. Implement a base class with account properties, deposit, withdrawal, and transaction logging.
    //3.  Create two account types: one with interest and another allowing overdraft.
    //4.  Use a constructor for account initialization and a dynamic creation mechanism.
    //5.  Create a utility class for account number generation and file handling.
    //6.  Split operations into multiple files, use static members for interest rates and minimum balance.
    //7. Store and retrieve account details using file handling with transaction logs.
    //8.  Maintain transaction history, display account details, and filter high-value transactions. 
    //9.  Notify users on transactions and ensure proper error handling.
    //10. Handle insufficient balance and invalid account errors using exceptions. 
    //11.  Develop a secure, interactive, console-based banking application.

    class Program
    {
        static void Main(string[] args)
        {
            AccountServices services = new AccountServices();

            while (true)
            {
                Console.WriteLine("\nSmart Banking System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. View Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        services.CreateAccount();
                        break;
                    case 2:
                        services.PerformDeposit();
                        break;
                    case 3:
                        services.PerformWithdrawal();
                        break;
                    case 4:
                        services.ViewAccount();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
