using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class OutOfStockException : Exception
    {
        public OutOfStockException()
        {
            Console.WriteLine("This item is out of stock for the moment !!! We will fill it up soon !!!");
        }
    }
}
