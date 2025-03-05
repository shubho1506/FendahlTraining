using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class DineInOrder : Order
    {
        public override void PlaceOrder(string dish)
        {
            Console.WriteLine($"Your Dine-in order of {dish} has been placed....");
        }
    }
}
