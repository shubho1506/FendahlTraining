using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class TakeawayOrder : Order
    {
        public override void PlaceOrder(string dish)
        {
            Console.WriteLine($"Your Take-away order of {dish} has been placed....");
        }
    }
}
