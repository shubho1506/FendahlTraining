using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class ProductNotFoundException : Exception
    {
        public ProductNotFoundException()
        {
            Console.WriteLine("Product not found !!! Please check if it is a valid product !!! ");
        }
    }
}
