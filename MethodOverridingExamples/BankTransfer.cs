using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class BankTransfer : Payment
    {
        public BankTransfer(string pName, double pAmount) : base(pName, pAmount)
        {
        }

        public override void ProcessPayment(double PAmount,double interest)
        {
            Console.WriteLine($"Your payment of {PAmount} with {PAmount * (interest / 100)} using bank transfer is in process...");
        }
    }
}
