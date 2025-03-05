using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class OnlineOrder : Order
    {
        public override void PlaceOrder(string dish,string taste)
        {
            Console.WriteLine($"Your Online order of {dish}({taste}) has been placed....");
        }
    }
}
