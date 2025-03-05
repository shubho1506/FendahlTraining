using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class BankTransferPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Your payment of {amount} through Bank Transfer has been processed...");
        }
    }
}
