using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    //3.	Shopping Cart:
    //o ShoppingCart class with AddProduct, RemoveProduct, ViewCart, CalculateTotal.
    //o LINQ for filtering high-value items and low-stock products.
    class ShoppingCart
    {
        internal List<Product> productCart = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ProductNotFoundException();
            }
            productCart.Add(product);
            Console.WriteLine($"{product.ProductName} added to cart.");
        }

        public void RemoveProduct(int productId)
        {
            var product = productCart.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                productCart.Remove(product);
                Console.WriteLine($"{product.ProductName} removed from cart.");
            }
            else
            {
                throw new ProductNotFoundException();
            }
        }

        public decimal CalculateTotal()
        {
            return productCart.Sum(p => p.ProductPrice);
        }

        public void ViewCart()
        {
            foreach (var product in productCart)
            {
                Console.WriteLine($"{product.ProductName} - ${product.ProductPrice}");
            }
            Console.WriteLine($"Total: ${CalculateTotal()}");
        }

        public List<Product> GetProductList()
        {
            return productCart;
        }
    }
}
