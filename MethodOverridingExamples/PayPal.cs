using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class PayPal : Payment
    {
        public PayPal(string pName, double pAmount) : base(pName, pAmount)
        {
        }

        public override void ProcessPayment(double PAmount)
        {
            Console.WriteLine($"Your payment of {PAmount} with paypal is in process...");
        }
    }
}
