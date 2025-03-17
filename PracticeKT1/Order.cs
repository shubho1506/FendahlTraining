using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    //4.	Order Processing:
    //o Order class with OrderID, User, CartItems, TotalAmount, Status(Pending, Shipped, Delivered).
    //o Store orders using file handling.
    class Order
    {
        internal int OrderID { get; set; }
        internal User OrderUser { get; set; }
        internal List<Product> OrderCartItems { get; set; }
        internal decimal OrderTotalAmount { get; set; }
        internal OrderStatus OrderStatus { get; set; }

        public Order(int id, User user, List<Product> cartItems,decimal amount)
        {
            OrderID = id;
            OrderUser = user;
            OrderCartItems = cartItems;
            OrderTotalAmount = amount;
            OrderStatus = OrderStatus.Pending;
        }
    }
}
