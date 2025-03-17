using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankingSystem
{
    class InvalidAccountException : Exception
    {
        public InvalidAccountException() : base("Invalid account number.") { }
    }
}
