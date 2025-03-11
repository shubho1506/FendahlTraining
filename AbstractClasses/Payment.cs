using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Scenario 1: Payment Processing System
    //A company provides multiple payment methods like Credit Card, PayPal, and Bank Transfer.
    //Each payment method has a ProcessPayment() method that follows a common structure but has different implementations for each payment type.
    //Question:
    //Design an abstract class Payment with a method ProcessPayment().
    //Implement CreditCardPayment, PayPalPayment, and BankTransferPayment classes that override this method.
    abstract class Payment
    {
        private Payment()
        {
            Console.WriteLine("This is private constructor. ");
        }

        //public Payment payment()
        //{
        //    return new Payment();
        //}
        public abstract void ProcessPayment(double amount);
    }
}
