using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() : base("Insufficient balance for the transaction.") { }
    }
}
