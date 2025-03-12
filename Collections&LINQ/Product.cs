using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LINQ
{
    class Product
    {
        public string ProductName { get; set; }
        public int QuantityOrdered { get; set; }

        public Product(string productName, int quantityOrdered)
        {
            ProductName = productName;
            QuantityOrdered = quantityOrdered;
        }
    }
}
