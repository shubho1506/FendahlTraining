using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProductPriceCalculator
{
    class Product
    {
        public string productName { get; set; }
        public string productCategory { get; set; }

        public Product(string productName, string prodCategory = null)
        {
            this.productName = productName;
            this.productCategory = prodCategory;
        }

    }
}
