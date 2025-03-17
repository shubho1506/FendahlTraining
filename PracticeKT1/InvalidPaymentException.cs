using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class InvalidPaymentException : Exception
    {
        public InvalidPaymentException()
        {
            Console.WriteLine("Invalid payment !!!");
        }
    }
}
