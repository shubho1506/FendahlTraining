using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProductPriceCalculator
{
    class CalcPrice
    {
        TaxCategory taxCategory = new TaxCategory();
        public void CalculatePrice(Product product, double price)
        {
            Console.WriteLine($"Price of {product.productName} is {price}");
        }

        public void CalculatePrice(Product product, double price,string category)
        {
            Console.WriteLine($"Price of {product.productName} is {price + price*(taxCategory.getTaxPrice(category) /100)}");
        }

        public void CalculatePrice(Product product, double price, string category, double discount)
        {
            Console.WriteLine($"Price of {product.productName} is {(price + price * (taxCategory.getTaxPrice(category) / 100))-(price*(discount/100))}");
        }
    }
}
