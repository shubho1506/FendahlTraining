using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class OrderService
    {
        internal static List<Order> orders = new List<Order>();

        internal static int id = orders.Count + 1;

        private User _user;
        private ShoppingCart _Cart;
        private ProductService _shop;

        public OrderService(User user, ShoppingCart cart, ProductService shop)
        {
            _user = user;
            _Cart = cart;
            _shop = shop;
        }
        public void AddProductToCart(int id)
        {
            Product product = _shop.GetProductById(id);
            _Cart.AddProduct(product);
        }

        public void PlaceOrder()
        {
            orders.Add(new Order(id++, _user, _Cart.GetProductList(), _Cart.CalculateTotal()));
            try
            {
                using (StreamWriter writer = new StreamWriter("PurchaseHistory.log", true))
                {
                    writer.WriteLine($"{DateTime.Now} {orders[id-2].OrderID},{_user.UserName},{orders[id-2].OrderTotalAmount},{orders[id-2].OrderStatus}\n ");
                    Console.WriteLine("Order placed successfully.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed: {ex.Message}");
            }
            
        }

        public void ViewOrderItems()
        {
            Console.WriteLine($"Order ID : {id}");
            Console.WriteLine($"Username : {_user.UserName}");
            foreach(var product in _Cart.GetProductList())
            {
                Console.WriteLine($"{product.ProductName} - {product.ProductPrice} - {product.ProductCategory}");
            }
            Console.WriteLine($"Total Amount : {_Cart.CalculateTotal()} rs");
            Console.WriteLine($"Order Status : {OrderStatus.Pending}");
        }

        public void ViewAllItems()
        {
            _shop.ViewAllProducts();
        }
    }
}
