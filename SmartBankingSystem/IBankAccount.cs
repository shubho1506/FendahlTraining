using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    interface IBankAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void LogTransaction(string transactionType, decimal amount);
    }
}
