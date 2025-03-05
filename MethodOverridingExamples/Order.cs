using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Order
    {
        //2. Restaurant Ordering System
        //Scenario: A restaurant system processes different types of orders(Dine-in, Takeaway, Online).
        //•	Create a base class Order with a method PlaceOrder().
        //•	Override it in DineInOrder, TakeawayOrder, and OnlineOrder.
        //•	Overload PlaceOrder() to handle different order types.

        public virtual void PlaceOrder(string dish)
        {
            Console.WriteLine($"your order of {dish} has been placed....");
        }

        public virtual void PlaceOrder(string dish, string taste)
        {
            Console.WriteLine($"your order of {dish}({taste}) has been placed....");

        }
    }
}
