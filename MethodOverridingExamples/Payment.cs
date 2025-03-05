using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Payment
    {
        public string PName { get; set; }
        public double PAmount { get; set; }

        public Payment(string pName, double pAmount)
        {
            PName = pName;
            PAmount = pAmount;
        }

        public virtual void ProcessPayment(double PAmount)
        {
            Console.WriteLine($"Your payment of {PAmount} is in process... ");
        }

        public virtual void ProcessPayment(double PAmount, double interestRate)
        {
            Console.WriteLine($"Your payment of {PAmount} with {PAmount*(interestRate/100)}is in process... ");
        }
    }
}
